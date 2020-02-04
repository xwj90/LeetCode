/*
 * @lc app=leetcode id=714 lang=csharp
 *
 * [714] Best Time to Buy and Sell Stock with Transaction Fee
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices, int fee)
    {
        var cash = 0;
        var hold = -prices[0];
        for (var i = 0; i < prices.Length; i++)
        {
            cash = Math.Max(cash, hold + prices[i] - fee);
            hold = Math.Max(hold, cash - prices[i]);
        }
        return cash;
    }
}
// @lc code=end

