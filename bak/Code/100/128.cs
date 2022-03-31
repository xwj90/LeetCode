using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var v = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if(!dict.ContainsKey(item))
            {
                var left = dict.ContainsKey(item - 1) ? dict[item - 1] : 0;
                var right = dict.ContainsKey(item + 1) ? dict[item + 1] : 0;

                int sum = left + right + 1;
                dict[item] = sum;
                v = Math.Max(v, sum);
                dict[item - left] = sum;
                dict[item + right] = sum;
            }
        }
        return v;
    }
}