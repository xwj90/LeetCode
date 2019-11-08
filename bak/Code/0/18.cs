using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{


    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        List<IList<int>> rs = new List<IList<int>>();
        if (nums.Length < 4) return rs;
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target) break; //it is too large
            if (nums[i] + nums[nums.Length - 1] + nums[nums.Length - 2] + nums[nums.Length - 3] < target) continue; //it is too small
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (nums[i] + nums[j] + nums[j + 1] + nums[j + 2] > target) break; //it is too large
                if (nums[i] + nums[j] + nums[nums.Length - 1] + nums[nums.Length - 2] < target) continue;//it is too small
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                var left = j + 1;
                var right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[i] + nums[j] + nums[left] + nums[right] == target)
                    {
                        rs.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                        while (left < right && nums[right - 1] == nums[right]) right--;
                        while (left < right && nums[left + 1] == nums[left]) left++;
                        left++;
                        right--;
                    }
                    else if(nums[i] + nums[j] + nums[left] + nums[right] > target)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
        }
        return rs;
    }
}