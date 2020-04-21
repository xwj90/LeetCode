public class Solution
{
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        var map = new Dictionary<string, List<string>>();
        wordList.Add(beginWord);
        wordList = wordList.Distinct().ToList();
        for (var i = 0; i < wordList.Count; i++)
            for (var j = 0; j < wordList.Count; j++)
                if (i != j && Diff(wordList[i], wordList[j]) == 1)
                    if (!map.ContainsKey(wordList[i])) map[wordList[i]] = new List<string>() { wordList[j] };
                    else map[wordList[i]].Add(wordList[j]);

        var res = new List<IList<string>>();
        var hs = new HashSet<string>() { beginWord };


        var nodes = new List<(string, List<string> Path)>() { (beginWord, new List<string>()) };

        while (nodes.Any())
        {
            var newNodes = new List<(string, List<string> Path)>();
            foreach (var (node, path) in nodes)
                if (node == endWord)
                {
                    path.Add(node);
                    res.Add(path);
                }
                else if (map.ContainsKey(node))
                    foreach (var next in map[node])
                        if (!hs.Contains(next))
                        {
                            var newPath = new List<string>(path);
                            newPath.Add(node);
                            newNodes.Add((next, newPath));
                        }

            foreach (var (node, path) in newNodes)
                hs.Add(node);
            nodes = newNodes.ToList();
        }

        return res;
    }

    private int Diff(string s, string s2)
    {
        var d = 0;
        for (var i = 0; i < s.Length; i++)
            if (s[i] != s2[i]) d++;
        return d;
    }
}