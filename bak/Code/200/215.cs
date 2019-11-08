using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        List<int> r = new List<int>() { nums[0] };
        var greaterCount = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[0])
            {
                r.Insert(0, nums[i]);
                greaterCount++;
            }
            else
                r.Add(nums[i]);
        }
        if (greaterCount + 1 == k)
            return r[greaterCount];
        else if (greaterCount + 1 > k)
            return FindKthLargest(r.Take(greaterCount).ToArray(), k);
        else
            return FindKthLargest(r.Skip(greaterCount + 1).ToArray(), k - greaterCount - 1);
    }

}

