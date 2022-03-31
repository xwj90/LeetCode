using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    Dictionary<string, List<string>> WordBreak_dict = new Dictionary<string, List<string>>();
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        if (WordBreak_dict.ContainsKey(s))
            return WordBreak_dict[s];
        List<string> ls = new List<string>();
        foreach (var item in wordDict)
        {
            if (s.StartsWith(item))
            {
                if (s == item)
                {
                    ls.Add(s);
                }
                else
                {
                    foreach (var n in WordBreak(s.Substring(item.Length), wordDict))
                    {
                        ls.Add(item + " " + n);
                    }
                   
                }
            }
        }
        WordBreak_dict[s] = ls;
        return ls;
    }
}