/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var hs = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            hs[nums[i]] = i;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var goal = target - nums[i];
            if (hs.ContainsKey(goal)&& hs[goal] != i)
            {
                return new int[] { i, hs[goal] };
            }
        }
        return new int[] { };
    }
}
// @lc code=end

