using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{


    public int NumDistinct(string s, string t)
    {
        int[,] a = new int[t.Length + 1, s.Length + 1];
        for (int i = 0; i <= s.Length; i++)
            a[0, i] = 1;

        for (int i = 0; i < t.Length; i++)
            for (int j = 0; j < s.Length; j++)
                if (s[j] == t[i])
                    a[i + 1, j + 1] = a[i, j] + a[i + 1, j];
                else
                    a[i + 1, j + 1] = a[i + 1, j];

        return a[t.Length, s.Length];
    }
}