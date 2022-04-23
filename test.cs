public class Trie
{
    public Dictionary<char, Trie> dictionary = new();
    public bool IsWord;

    public void Insert(string word, int start = 0)
    {
        if (start >= word.Length)
            return;
        if (!dictionary.ContainsKey(word[start]))
        {
            dictionary[word[start]] = new Trie();
        }
        dictionary[word[start]].Insert(word, start + 1);
        if (start == word.Length - 1)
        {
            dictionary[word[start]].IsWord = true;
        }
    }
    public int Search(string sentence, int start, int len = 1)
    {
        if (!dictionary.ContainsKey(sentence[start]))
        {
            return -1;
        }
        else
        {
            var node = dictionary[sentence[start]];
            if (node.IsWord)
                return len;
            return dictionary[sentence[start]].Search(sentence, start + 1, len + 1);
        }

    }
}
public class Solution
{
    public List<string> BreakSentence(string s, string[] phrases)
    {
        var dummy = new Trie();
        foreach (var phrase in phrases)
        {
            dummy.Insert(phrase);
        }
        var res = new List<string>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                continue;
            var len = dummy.Search(s, i);
            if (len > 0)
            {
                res.Add(s.Substring(i, len));
                i += len;
            }
            else
            {
                var space = s.IndexOf(' ', i);
                var next = space >= 0 ? space : s.Length;
                res.Add(s.Substring(i, next - i));
                i = next;
            }
        }
        return res;
    }
}

Console.WriteLine(string.Join(",", new Solution().BreakSentence("Microsoft  is developing Office 365", new[] { "Office 365", "Microsoft Office" })));
Console.WriteLine(string.Join(",", new Solution().BreakSentence("Microsoft  is developing Office 365", new string[] { })));
Console.WriteLine(string.Join(",", new Solution().BreakSentence("Microsoft  is developing Office 365 Office 365 test", new[] { "Office 365", "developing Office" })));