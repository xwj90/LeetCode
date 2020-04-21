public class WordDictionary
{

    /** Initialize your data structure here. */
    TrieNode root = new TrieNode();
    public WordDictionary()
    {

    }

    /** Adds a word into the data structure. */
    public void AddWord(string word)
    {
        root.Insert(word, 0);
    }

    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word)
    {
        return root.Search(word, 0);
    }

    public class TrieNode
    {
        public char Value;
        public TrieNode[] Children = new TrieNode[26];
        public bool End;

        public void Insert(string s, int start)
        {
            if (s.Length > start)
            {
                var idx = s[start] - 'a';
                if (this.Children[idx] == null) this.Children[idx] = new TrieNode() { Value = s[start] };
                this.Children[idx].Insert(s, start + 1);
                if (start == s.Length - 1) this.Children[idx].End = true;
            }
        }
        public bool Search(string s, int start)
        {
            var status = false;
            if (s.Length > start)
            {
                var idx = s[start] - 'a';
                if (s.Length - 1 == start)
                {
                    if (s[start] == '.') return this.Children.Any(p => p != null && p.End);
                    else return this.Children[idx] != null && this.Children[idx].End;
                }
                else if (s[start] == '.')
                {
                    foreach (var node in this.Children.Where(p => p != null))
                    {
                        if (node.Search(s, start + 1)) return true;
                    }
                }
                else
                {
                    if (this.Children[idx] == null) return false;
                    return this.Children[idx].Search(s, start + 1);
                }
            }
            return status;
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
// @lc code=end

