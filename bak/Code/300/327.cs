using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 327. Count of Range Sum
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="lower"></param>
    /// <param name="upper"></param>
    /// <returns></returns>
    public int CountRangeSum(int[] nums, int lower, int upper)
    {
        long[] sums = new long[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
            sums[i + 1] = sums[i] + nums[i];
        List<long> sort = new List<long>() { 0 };
        int total = 0;

        for (int i = 1; i < sums.Length; i++)
        {

            var maxIndex = CountRangeSum_FindIndex(sort, sums[i] - lower + 0.5); //total sums - pre sums > lower
            var minIndex = CountRangeSum_FindIndex(sort, sums[i] - upper - 0.5); // total sums-  pre sums < upper
            total += maxIndex - minIndex;
            sort.Insert(CountRangeSum_FindIndex(sort, sums[i]), sums[i]);
        }
        return total;
    }
    private int CountRangeSum_FindIndex(List<long> a, double val)
    {
        var l = 0;
        var r = a.Count - 1;
        var m = 0;
        while (l <= r)
        {
            m = (l + r) / 2;
            if (a[m] > val)
                r = m - 1;
            else
                l = m + 1;
        }
        return l;
    }


}