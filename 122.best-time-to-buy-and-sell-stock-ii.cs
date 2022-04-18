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
        var profit = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            if(prices[i]>prices[i-1])
            profit+=prices[i]-prices[i-1];
        }
        return profit;
    }
}
// @lc code=end

