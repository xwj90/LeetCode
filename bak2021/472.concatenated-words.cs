public class Solution
{
    public IList<string> FindAllConcatenatedWordsInADict(string[] words)
    {
        TrieNode root = new TrieNode();
        var ws = words.Where(p => !string.IsNullOrWhiteSpace(p));
        foreach (var w in ws)
        {
            root.Insert(w);
        }

        var res = new List<string>();
        foreach (var w in ws)
        {
            if (root.DFS(w, root, 0, 0))
                res.Add(w);
        }
        return res;
    }
    public class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        public bool IsEnd;
        public char Val;
        public void Insert(string s, int i = 0)
        {
            var idx = s[i] - 'a';
            if (Children[idx] == null)
                Children[idx] = new TrieNode() { Val = s[i] };
            if (i == s.Length - 1)
                Children[idx].IsEnd = true;
            else
                Children[idx].Insert(s, i + 1);
        }
        public bool DFS(string s, TrieNode root, int i = 0, int wordCount = 0)
        {
            var idx = s[i] - 'a';
            if (Children[idx] == null)
                return false;
            else if (i == s.Length - 1)
                return Children[idx].IsEnd && wordCount >= 1;
            else if (Children[idx].IsEnd)
                return root.DFS(s, root, i + 1, wordCount + 1) || Children[idx].DFS(s, root, i + 1, wordCount);
            else
                return Children[idx].DFS(s, root, i + 1, wordCount);

        }
    }
}
// @lc code=end

