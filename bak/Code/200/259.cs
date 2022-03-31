using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int ThreeSumSmaller(int[] nums, int target)
    {
        Array.Sort(nums);
        int count = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] < target)
                {
                    count += right - left;
                    left++;
                }
                else
                    right--;
            }
        }
        return count;
    }
}