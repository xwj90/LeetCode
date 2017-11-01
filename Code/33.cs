using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int mid = -1;
        while (left < right)
        {
            mid = (left + right) / 2;
            if (nums[mid] > nums[right])
                left = mid + 1;
            else
                right = mid;
        }
        var start = left;
        left = 0;
        right = nums.Length - 1;
        while (left <= right)
        {
            mid = (left + right) / 2;
            var id = (mid + start) % nums.Length;
            if (nums[id] == target)
                return id;
            else if (nums[id] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;

    }
}
