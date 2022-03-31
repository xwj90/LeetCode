public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var smallestOnLeft = new int[prices.Length];
        if(prices.Length==0) return 0;
        smallestOnLeft[0] = prices[0];
        var profit = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            profit = Math.Max(profit, prices[i] - smallestOnLeft[i - 1]);
            smallestOnLeft[i] = Math.Min(smallestOnLeft[i - 1], prices[i]);
        }
        return profit;
    }
}
// @lc code=end

