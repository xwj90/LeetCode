using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public void NextPermutation(int[] nums)
    {
        var max = nums[nums.Length - 1];
        var min = int.MaxValue;
        var start = -1;
        var end = -1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] < max)
            {
                start = i;
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[j] > nums[start] && nums[j] < min)
                    {
                        min = nums[j];
                        end = j;
                    }
                break;
            }
            else
                max = Math.Max(max, nums[i]);
        }
        if (start != -1)
        {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
        }

        Array.Sort(nums, start + 1, nums.Length - start - 1);
        
    }
}





