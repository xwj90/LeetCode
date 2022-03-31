using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 81. Search in Rotated Sorted Array II
    /// don't compile this file due to duplicated method
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool Search(int[] nums, int target)
    {
        //find split
        var id = 0;
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] < nums[i - 1])
            {
                id = i;
                break;
            }

        var left = 0;
        var right = nums.Length - 1;
        var mid = 0;
        while (left <= right)
        {
            mid = (left + right) / 2;
            var e = (mid + id) % nums.Length;
            if (nums[e] == target)
                return true;
            else if (nums[e] > target)
                right = mid - 1;
            else
                left = mid + 1;
        }
        return false;
    }
}
