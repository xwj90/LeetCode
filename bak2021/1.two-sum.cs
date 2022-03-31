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
            hs[target - nums[i]] = i;
        }
        for (var i = 0; i < nums.Length; i++)
        {
            if (hs.ContainsKey(nums[i]) && i != hs[nums[i]])
            {
                return new int[] { i, hs[nums[i]] };
            }
        }
        return null;
    }
}
// @lc code=end

