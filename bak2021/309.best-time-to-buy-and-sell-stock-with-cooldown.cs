/*
 * @lc app=leetcode id=309 lang=csharp
 *
 * [309] Best Time to Buy and Sell Stock with Cooldown
 */
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int sell = 0;
        int prev_sell = 0;
        int buy = int.MinValue;
        int prev_buy;
        foreach (int price in prices)
        {
            prev_buy = buy;
            buy = Math.Max(prev_sell - price, prev_buy);
            prev_sell = sell;
            sell = Math.Max(prev_buy + price, prev_sell);
        }
        return sell;
    }
}

