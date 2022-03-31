using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        List<char> ls = new List<char>();
        foreach (var p in s.ToLower())
        {
            var v = p - 'a';
            var v2 = p - '0';
            if ((v >= 0 && v <= 25) || (v2 >= 0 && v2 <= 9))
                ls.Add(p);
        }
        while (ls.Count > 1)
        {
            if (ls[0] != ls[ls.Count - 1])
                return false;
            ls.RemoveAt(ls.Count - 1);
            ls.RemoveAt(0);
        }
        return true;
    }
}