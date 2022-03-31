/*
 * @lc app=leetcode id=494 lang=csharp
 *
 * [494] Target Sum
 */

// @lc code=start
public class Solution
{
    Dictionary<(int, int), int> dict = new Dictionary<(int, int), int>();
    public int FindTargetSumWays(int[] nums, int S)
    {
        return FindTargetSumWays(nums, 0, S);
    }

    public int FindTargetSumWays(int[] nums, int start, int S)
    {
        if (dict.ContainsKey((start, S))) return dict[(start, S)];
        if (start == nums.Length) return S == 0 ? 1 : 0;
        var v1 = FindTargetSumWays(nums, start + 1, S - nums[start]);
        var v2 = FindTargetSumWays(nums, start + 1, S + nums[start]);
        dict[(start, S)] = v1 + v2;
        return v1 + v2;
    }
}
// @lc code=end

