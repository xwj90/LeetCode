using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// Count of Range Sum
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="lower"></param>
    /// <param name="upper"></param>
    /// <returns></returns>
    public int CountRangeSum(int[] nums, int lower, int upper)
    {
        throw new NotImplementedException();
        long[] sums = new long[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
            sums[i + 1] = sums[i] + nums[i];

    }
}