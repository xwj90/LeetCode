/*
 * @lc app=leetcode id=140 lang=csharp
 *
 * [140] Word Break II
 */
public class Solution
{

    Dictionary<string, List<string>> WordBreak_dict = new Dictionary<string, List<string>>();
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        if (WordBreak_dict.ContainsKey(s))
        {
            return WordBreak_dict[s];
        }

        var ls = new List<string>();
        foreach (var word in wordDict)
        {
            if (s == word)
            {
                ls.Add(word);
            }
            else if (s.StartsWith(word))
            {
                var results = WordBreak(s.Substring(word.Length), wordDict).Select(p => $"{word} {p}");
                ls.AddRange(results);
            }
        }
        WordBreak_dict[s] = ls;
        return ls;
    }
}

