using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public string ConvertToBase7(int num)
    {
        var v = Math.Abs(num);
        List<int> r = new List<int>();
        while (v > 0)
        {
            r.Insert(0, v % 7);
            v = v / 7;
        }
        var s = string.Join("", r);
        return (num >= 0 ? "" : "-") + (string.IsNullOrWhiteSpace(s) ? "0" : s);
    }
}