using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public int FindSubstringInWraproundString(string p)
    {
        Dictionary<char, int> len = new Dictionary<char, int>();
        for (int start = 0; start < p.Length; start++)
        {
            var end = start;
            while (start == end ||
                (end < p.Length && ((p[end] - p[end - 1] == 1) || (p[end] == 'a' && p[end - 1] == 'z'))))
            {
                if (!len.ContainsKey(p[end]))
                    len[p[end]] = 0;
                len[p[end]] = Math.Max(len[p[end]], end - start + 1);
                end++;
            }
            start = end - 1;
        }
        return len.Sum(q => q.Value);
    }


}