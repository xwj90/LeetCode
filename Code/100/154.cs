using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int FindMin(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        var mid = 0;
        while (left < right)
        {
            //mid = (left + right) / 2;
            mid = left + (right - left) / 2;
            if (nums[mid] > nums[right])
                left = mid + 1;
            else if (nums[mid] < nums[right])
                right = mid;
            else
                right--;
        }
        return nums[left];

    }
}