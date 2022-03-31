/*
 * @lc app=leetcode id=122 lang=csharp
 *
 * [122] Best Time to Buy and Sell Stock II
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {

        if (prices.Length == 0) return 0;
        var prev = prices[0];
        var profit = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prev)
            {
                profit += prices[i] - prev;
                prev = prices[i];
            }
            else
            {
                prev = prices[i];
            }
        }
        return profit;

    }
}
// @lc code=end

