using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0)
            return new int[] { -1, -1 };
        else if (nums.Length == 1 && nums[0] == target)
            return new int[] { 0, 0 };
        else if (nums.Length == 1)
            return new int[] { -1, -1 };
        int[] r = new int[2];
        var left = 0;
        var right = nums.Length;
        var mid = 0;
        while (left < right)
        {
            mid = (left + right) / 2;
            if (nums[mid] >= target)
                right = mid;
            else
                left = mid + 1;
        }
        r[0] = left > nums.Length - 1 || nums[left] != target ? -1 : left;

        left = 0;
        right = nums.Length;

        while (left < right)
        {
            mid = (left + right) / 2;
            if (nums[mid] <= target)
                left = mid + 1;
            else
                right = mid;
        }
        r[1] = left > nums.Length || left == 0 || nums[left - 1] != target ? -1 : left - 1;

        //r[1] = nums[left] == target ? left : -1;
        return r;
    }
}
