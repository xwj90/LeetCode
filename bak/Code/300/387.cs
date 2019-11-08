using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char,int> d = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
            if (d.ContainsKey(s[i]))
                d[s[i]]++;
            else
                d[s[i]] = 1;

        for (int i = 0; i < s.Length; i++)
            if (d[s[i]] == 1)
                return i;
        return -1;    
    }
}

