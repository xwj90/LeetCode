//no idea why it is not working
public class FileSystem
{
    public Node root = new Node();

    public IList<string> Ls(string path)
    {
        var paths = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        return root.LS(paths, 0);
    }

    public void Mkdir(string path)
    {
        var paths = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        root.Insert(paths, 0, false);
    }

    public void AddContentToFile(string filePath, string content)
    {
        var paths = filePath.Split('/', StringSplitOptions.RemoveEmptyEntries);
        root.Insert(paths, 0, true, content);
    }

    public string ReadContentFromFile(string filePath)
    {
        var paths = filePath.Split('/', StringSplitOptions.RemoveEmptyEntries);
        return root.Read(paths, 0);
    }

    public class Node
    {
        public string Name;
        public SortedList<string, Node> Paths = new SortedList<string, Node>();
        public string Content;
        public bool IsFile;

        public void Insert(string[] paths, int idx, bool isFile, string content = null)
        {
            if (idx < paths.Length)
            {
                var key = paths[idx];
                if (!this.Paths.ContainsKey(key))
                    this.Paths[key] = new Node() { Name = key };

                if (idx < paths.Length - 1)
                    this.Paths[key].Insert(paths, idx + 1, isFile, content);
                else
                {
                    this.Paths[key].IsFile = isFile;
                    this.Paths[key].Content += content;
                }
            }
        }

        public List<string> LS(string[] paths, int idx)
        {
            if (paths.Length == 0)
                return this.Paths.Keys.ToList();
            if (idx < paths.Length)
            {
                var key = paths[idx];
                if (this.Paths.ContainsKey(key))
                {
                    if (idx < paths.Length - 1)
                        return this.Paths[key].LS(paths, idx + 1);
                    else if (this.Paths[key].IsFile)
                        return new List<string>(){key};
                    else
                        return this.Paths[key].Paths.Keys.ToList();
                }
            }
            return new List<string>();
        }

        public string Read(string[] paths, int idx)
        {
            if (idx < paths.Length)
            {
                var key = paths[idx];
                if (this.Paths.ContainsKey(key))
                {
                    if (idx < paths.Length - 1)
                        return this.Paths[key].Read(paths, idx + 1);
                    else
                        return this.Paths[key].IsFile ? this.Paths[key].Content : null;
                }

            }
            return null;
        }
    }
}

/**
 * Your FileSystem object will be instantiated and called as such:
 * FileSystem obj = new FileSystem();
 * IList<string> param_1 = obj.Ls(path);
 * obj.Mkdir(path);
 * obj.AddContentToFile(filePath,content);
 * string param_4 = obj.ReadContentFromFile(filePath);
 */
