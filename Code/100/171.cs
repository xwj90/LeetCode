
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int TitleToNumber(string s)
    {
        var result = 0;
        for (int i = 0; i < s.Length; i++)
            result = ((s[i] - 'A') + 1) + result * 26;
        return result;
    }
}