/*
 * @lc app=leetcode id=16 lang=csharp
 *
 * [16] 3Sum Closest
 */

// @lc code=start
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {

        Array.Sort(nums);

        var dis = int.MaxValue;
        var result = int.MaxValue;

        for (var i = 0; i < nums.Length - 2; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var v = nums[i] + nums[left] + nums[right];
                var diff = v - target;
                if (diff == 0)
                    return target;
                else if (diff > 0)
                    right--;
                else
                    left++;

                if (Math.Abs(diff) < dis)
                {
                    dis = Math.Abs(diff);
                    result = v;
                }
            }
        }
        return result;
    }
}
// @lc code=end

