/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 */

// @lc code=start
public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        if (nums.Length == 0) return 0;
        var dp = new int[nums.Length];
        dp[0] = 1;
        for (var i = 1; i < dp.Length; i++)
        {
            var maxVal = 0;
            for (var j = 0; j < i; j++)
                if (nums[i] > nums[j])
                    maxVal = Math.Max(maxVal, dp[j]);

            dp[i] = maxVal + 1;
        }

        return dp.Max();
    }
}
// @lc code=end

