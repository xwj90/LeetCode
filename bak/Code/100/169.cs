
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (var v in nums)
            if (!dict.ContainsKey(v))
                dict[v] = 1;
            else
                dict[v]++; 
        foreach (var pair in dict)
        {
            if (pair.Value * 2 > nums.Length)
                return pair.Key;
        }
        return -1;
    }
}