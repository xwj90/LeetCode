/*
 * @lc app=leetcode id=474 lang=csharp
 *
 * [474] Ones and Zeroes
 */

// @lc code=start
public class Solution
{
    public int FindMaxForm(string[] strs, int m, int n)
    {
        var dp = new int[m + 1, n + 1];
        var init = false;
        foreach (var str in strs)
        {
            var zero = str.Count(c => c == '0');
            var one = str.Length - zero;

            for (var i = m; i >= zero; i--)
            {
                for (var j = n; j >= one; j--)
                {
                    dp[i, j] = Math.Max(dp[i, j], dp[i - zero, j - one] + 1);
                }
            }
        }
        return dp[m, n];
    }
}
// @lc code=end

