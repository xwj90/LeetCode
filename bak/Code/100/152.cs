using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MaxProduct(int[] nums)
    {
        var r = nums[0];
        for (int i = 1, max = r, min = r; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                var temp = min;
                min = max;
                max = temp;
            }
            max = Math.Max(nums[i], max * nums[i]);
            min = Math.Min(nums[i], min * nums[i]);
            r = Math.Max(r, max);
        }
        return r;
    }
}