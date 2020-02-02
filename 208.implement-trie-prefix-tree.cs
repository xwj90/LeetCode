public class Trie
{

    /** Initialize your data structure here. */
    Node root = new Node();
    public Trie()
    {

    }

    /** Inserts a word into the trie. */
    public void Insert(string word)
    {
        var head = root;
        for (var i = 0; i < word.Length; i++)
        {
            if (!head.Children.ContainsKey(word[i])) head.Children[word[i]] = new Node() { Value = word[i] };
            if (i == word.Length - 1) head.Children[word[i]].IsEnd = true;
            else head = head.Children[word[i]];
        }
    }

    /** Returns if the word is in the trie. */
    public bool Search(string word)
    {
        var head = root;
        for (var i = 0; i < word.Length; i++)
        {
            if (!head.Children.ContainsKey(word[i])) return false;
            if (i == word.Length - 1) return head.Children[word[i]].IsEnd;
            else head = head.Children[word[i]];
        }
        return false;
    }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix)
    {
        var head = root;
        for (var i = 0; i < prefix.Length; i++)
        {
            if (!head.Children.ContainsKey(prefix[i])) return false;
            if (i == prefix.Length - 1) return true;
            else head = head.Children[prefix[i]];
        }
        return false;
    }
}
public class Node
{
    public char Value;
    public bool IsEnd;

    public Dictionary<char, Node> Children = new Dictionary<char, Node>();
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
// @lc code=end

