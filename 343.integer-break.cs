/*
 * @lc app=leetcode id=343 lang=csharp
 *
 * [343] Integer Break
 */

// @lc code=start
public class Solution
{
    public int IntegerBreak(int n)
    {
        var dp = new int[n + 1];
        dp[2] = 1;
        for (var i = 3; i <= n; i++)
        {
            for (var j = 1; j < i - 1; j++)
            {
                dp[i] = Math.Max(dp[i], Math.Max(j * dp[i - j], j * (i - j)));
            }
        }
        return dp[n];

    }
}
// @lc code=end

