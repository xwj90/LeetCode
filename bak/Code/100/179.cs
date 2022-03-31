
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public string LargestNumber(int[] nums)
    {
        var s = nums.Select(p => p.ToString()).ToList();
        s.Sort((x, y) => -(x + y).CompareTo(y + x));
        return string.IsNullOrWhiteSpace(string.Join("", s).TrimStart('0'))?"0": string.Join("", s).TrimStart('0');
    }

}