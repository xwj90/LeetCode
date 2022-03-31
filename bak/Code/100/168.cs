
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public string ConvertToTitle(int n)
    {
        var r = "";
        var num = n;
        while (num > 0)
        {
            num--;
            r = (char)('A' + num % 26) + r;
            num /= 26;
        }
        return r;
    }
}