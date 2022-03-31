using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution1
{
    Dictionary<string, bool> WordBreak_dict = new Dictionary<string, bool>();
    public bool WordBreak(string s, IList<string> wordDict)
    {
        if (WordBreak_dict.ContainsKey(s))
            return WordBreak_dict[s];
        var status = false;
        foreach (var w in wordDict)
        {
            if (s.StartsWith(w))
            {
                var newWord = s.Substring(w.Length);
                if (newWord.Length == 0)
                {
                    status = true;
                    break;
                }
                if (WordBreak(newWord, wordDict))
                {
                    status = true;
                    break;
                }
            }
        }
        WordBreak_dict[s] = status;
        return status;
    }
}