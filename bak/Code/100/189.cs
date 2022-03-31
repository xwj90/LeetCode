
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        Rotate_Reverse(nums, 0, nums.Length - 1);
        Rotate_Reverse(nums, 0, k - 1);
        Rotate_Reverse(nums, k, nums.Length - 1);

    }
    private void Rotate_Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}