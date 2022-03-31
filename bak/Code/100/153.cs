using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int FindMin(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left < right)
        {
            if (nums[left] < nums[right])
                return nums[left];
            var mid = (left + right) / 2;
            if (nums[mid] >= nums[left]) left = mid + 1;
            else if (nums[mid] < nums[right]) right = mid;
        }
        return nums[left];
    }
}