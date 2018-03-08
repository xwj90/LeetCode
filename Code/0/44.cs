using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 44. Wildcard Matching 
    /// please change method name to IsMatch
    /// </summary>
    /// <param name="s"></param>
    /// <param name="p"></param>
    /// <returns></returns>
    public bool IsMatch_44(string s, string p)
    {
        var i = 0;
        var j = 0;
        var i_M = -1;
        var j_M = -1;
        while (i < s.Length)
        {
            if (j < p.Length && (s[i] == p[j] || p[j] == '?'))
            {
                i++;
                j++;
            }
            else if (j < p.Length && p[j] == '*')
            {
                i_M = i;
                j_M = j;
                j++;
            }
            else if (j_M != -1)
            {
                j = j_M + 1;
                i = ++i_M;
            }
            else return false;
        }
        while (j < p.Length && p[j] == '*')
           j++;
        return j == p.Length;
    }

}
