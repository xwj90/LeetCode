/*
 * @lc app=leetcode id=1049 lang=csharp
 *
 * [1049] Last Stone Weight II
 */

// @lc code=start
public class Solution
{
    public int LastStoneWeightII(int[] stones)
    {
        var dp = new int[15001];
        var sum = stones.Sum();
        var target = sum / 2;
        for (var i = 0; i < stones.Length; i++)
        {
            for (var j = target; j >= stones[i]; j--)
            {
                dp[j] = Math.Max(dp[j], dp[j - stones[i]] + stones[i]);
            }
        }
        return sum - dp[target] *2;
    }
}
// @lc code=end

