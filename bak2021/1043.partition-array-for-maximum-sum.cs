/*
 * @lc app=leetcode id=1043 lang=csharp
 *
 * [1043] Partition Array for Maximum Sum
 */

// @lc code=start
public class Solution
{
    public int MaxSumAfterPartitioning(int[] A, int K)
    {
        var dp = new int[A.Length];
        for (var i = 0; i < A.Length; i++)
        {
            var curMax = 0;
            for (int j = 1; j <= K && i - j + 1 >= 0; j++)
            {
                curMax = Math.Max(curMax, A[i - j + 1]);
                dp[i] = Math.Max(dp[i], (i >= j ? dp[i - j] : 0) + curMax * j);
            }
        }
        return dp[dp.Length - 1];
    }
}
// @lc code=end

