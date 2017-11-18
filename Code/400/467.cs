using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public int FindSubstringInWraproundString(string p)
    {
        HashSet<string> hs = new HashSet<string>();
        for (int i = 0; i < p.Length; i++)
        {
            for (int j = 1; i + j <= p.Length; j++)
            {
                if (j == 1 || (p[i + j - 1] - p[i + j - 2] + 26) % 26 == 1)
                    hs.Add(p.Substring(i, j));
                else
                    break;
            }
        }
        return hs.Count;
    }
}