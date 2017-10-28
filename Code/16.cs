using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var v = nums[0] + nums[1] + nums[2];
        for (int i = 0; i < nums.Length; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;
            while (right > left)
            {
                var t = nums[i] + nums[left] + nums[right];
                if (t == target)
                {
                    return target;
                }
                else if (t > target)
                {
                    v = Math.Abs(target - v) <= Math.Abs(target - t) ? v : t;
                    right--;
                }
                else
                {
                    v = Math.Abs(target - v) <= Math.Abs(target - t) ? v : t;
                    left++;
                }
            }
        }
        return v;
    }

}