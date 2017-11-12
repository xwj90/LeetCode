using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MaxSubArray(int[] nums)
    {
        var max = int.MinValue;
        var v = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            v += nums[i];
            max = Math.Max(max, v);
            if (v<0)
                v = 0;          
        }
        return max;
    }
}
