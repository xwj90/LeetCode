public class MagicDictionary
{
    private HashSet<string> words = new HashSet<string>();
    private Dictionary<string, int> count = new Dictionary<string, int>();

    /** Initialize your data structure here. */
    public MagicDictionary()
    {

    }

    /** Build a dictionary through a list of words */
    public void BuildDict(string[] dict)
    {
        foreach (var w in dict)
        {
            this.words.Add(w);
            foreach (var s in GetNeighbors(w))
            {
                count.TryGetValue(s, out int c);
                count[s] = c + 1;
            }
        }
    }

    public List<string> GetNeighbors(string w)
    {
        var list = new List<string>();
        var a = w.ToCharArray();
        for (var i = 0; i < a.Length; i++)
        {
            a[i] = '*';
            list.Add(new string(a));
            a[i] = w[i];
        }
        return list;
    }

    /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
    public bool Search(string w)
    {
        foreach (var s in GetNeighbors(w))
        {
            if (count.TryGetValue(s, out int c))
            {
                if (c > 1) return true;
                if (c == 1 && !words.Contains(w)) return true;
            }
        }
        return false;
    }
}

/**
 * Your MagicDictionary object will be instantiated and called as such:
 * MagicDictionary obj = new MagicDictionary();
 * obj.BuildDict(dict);
 * bool param_2 = obj.Search(word);
 */
// @lc code=end

