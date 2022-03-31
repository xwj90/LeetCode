using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MinCut(string s)
    {
        int[] cuts = new int[s.Length + 1];
        for (int i = 0; i <= s.Length; i++)
            cuts[i] = i - 1;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; i - j >= 0 && i + j < s.Length && s[i - j] == s[i + j]; j++)
                cuts[i + j + 1] = Math.Min(cuts[i + j + 1], 1 + cuts[i - j]);
            for (int j = 1; i - j + 1 >= 0 && i + j < s.Length && s[i - j + 1] == s[i + j]; j++) // even length palindrome
                cuts[i + j + 1] = Math.Min(cuts[i + j + 1], 1 + cuts[i - j + 1]);
        }
        return cuts[s.Length];
    }
    //int[,] MinCut_table = null;
    //public int MinCut(string s)
    //{
    //    MinCut_table = new int[s.Length, s.Length];
    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        for (int j = i; j < s.Length; j++)
    //        {
    //            MinCut_BuildPalindromeTable(s, i, j);
    //        }
    //    }


    //}
    //int MinCut_BuildPalindromeTable(string s, int start, int end)
    //{

    //    if (MinCut_table[start, end] != 0)
    //        return MinCut_table[start, end];

    //    var status = -1;
    //    if ((end - start) <= 1)
    //        status = s[start] == s[end] ? 1 : -1;
    //    else
    //    {
    //        status = MinCut_BuildPalindromeTable(s, start++, end--);
    //    }
    //    MinCut_table[start, end] = status;
    //    return status;
    //}
}