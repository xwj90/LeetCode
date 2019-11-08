/*
 * @lc app=leetcode id=820 lang=csharp
 *
 * [820] Short Encoding of Words
 */
public class Solution
{
    public int MinimumLengthEncoding(string[] words)
    {
        TrieNode trie = new TrieNode();
        Dictionary<TrieNode, int> nodes = new Dictionary<TrieNode, int>();

        for (int i = 0; i < words.Length; ++i)
        {
            var word = words[i];
            TrieNode cur = trie;         
            for (int j = word.Length - 1; j >= 0; --j)
            {
                cur = cur.get(word[j]);
            }
            nodes[cur] = i;
        }

        int ans = 0;
        foreach (var node in nodes.Keys)
        {
            if (node.count == 0)
            {
                ans += words[nodes[node]].Length + 1;
            }
        }
        return ans;
    }
}
public class TrieNode
{
    TrieNode[] children;
    public int count;
    public TrieNode()
    {
        children = new TrieNode[26];
        count = 0;
    }
    public TrieNode get(char c)
    {
        if (children[c - 'a'] == null)
        {
            children[c - 'a'] = new TrieNode();
            count++;
        }
        return children[c - 'a'];
    }
}