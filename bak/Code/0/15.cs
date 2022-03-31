using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
   
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> rs = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            //check if 2 number's sum = 0 - nums[i]
            var left = i + 1;
            var right = nums.Length - 1;
            while (right > left)
            {
                if (nums[i] + nums[left] + nums[right] == 0)
                {
                    rs.Add(new List<int> { nums[i], nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
                else if (nums[i] + nums[left] + nums[right] > 0)
                    right--;
                else
                    left++;

            }
        }
        return rs;
    }

}