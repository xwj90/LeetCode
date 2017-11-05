using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool IsScramble(string s1, string s2)
    {

        if (s1 == s2)
            return true;
        var len = s1.Length;
        int[] a = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            a[s1[i] - 'a']++;
            a[s2[i] - 'a']--;
        }
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != 0) return false;
        }
        for (int i = 1; i <= s1.Length - 1; i++)
        {
            if (IsScramble(s1.Substring(0, i), s2.Substring(0, i)) && IsScramble(s1.Substring(i), s2.Substring(i)))
                return true;
            if (IsScramble(s1.Substring(0, i), s2.Substring(len - i)) && IsScramble(s1.Substring(i), s2.Substring(0, len - i)))
                return true;
        }
        return false;
    }
}