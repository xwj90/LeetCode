using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public string FindLongestWord(string s, IList<string> d)
    {
        var candidates = d.OrderByDescending(p => p.Length).ThenBy(p => p);
        foreach (var c in candidates)
        {
            var start = 0;
            var check = 0;
            while (start < s.Length && check < c.Length)
            {
                if (s[start] == c[check])
                {
                    start++;
                    check++;
                }
                else
                {
                    start++;
                }
            }
            if (check == c.Length)
                return c;
        }
        return "";
    }
}