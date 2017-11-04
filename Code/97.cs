using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s3.Length != s1.Length + s2.Length)
            return false;
        bool[,] status = new bool[s1.Length + 1, s2.Length + 1];

        for (int i = 0; i <= s1.Length; i++)
        {
            for (int j = 0; j <= s2.Length; j++)
            {
                if (i == 0 && j == 0)
                    status[0, 0] = true;
                else if (i == 0)
                    status[i, j] = status[i, j - 1] && s2[j - 1] == s3[i + j - 1];
                else if (j == 0)
                    status[i, j] = status[i - 1, j] && s1[i - 1] == s3[i + j - 1];
                else
                    status[i, j] = (status[i, j - 1] && s2[j - 1] == s3[i + j - 1])|| (status[i - 1, j] && s1[i - 1] == s3[i + j - 1]);
            }
        }
        return status[s1.Length, s2.Length];
    }
    /* 
     * solution 2
    Dictionary<string, bool> IsInterleave_dict = new Dictionary<string, bool>();
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length == 0)
            return s2 == s3;
        else if (s2.Length == 0)
            return s1 == s3;
        else if (s3.Length != s1.Length + s2.Length)
            return false;
        else if (s3[0] != s2[0] && s3[0] != s1[0])
            return false;
        var key = s1 + s2 + s3;
        if (IsInterleave_dict.ContainsKey(key))
            return IsInterleave_dict[key];

        var status= (s3[0] == s1[0] && IsInterleave(s1.Substring(1), s2, s3.Substring(1)))
            || s3[0] == s2[0] && IsInterleave(s1, s2.Substring(1), s3.Substring(1));

        IsInterleave_dict[key] = status;
        return status;
    }
    */
}