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

        var sum = 0;
        var minPrice = prices[0];
        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];

            if (prices[i] > minPrice + fee)
            {
                sum += prices[i] - minPrice - fee;
                minPrice = prices[i] - fee;
            }
        }
        return sum;
    }
}
// @lc code=end

