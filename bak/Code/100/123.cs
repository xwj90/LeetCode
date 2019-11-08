using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MaxProfit(int[] prices)
    {
        int release1 = 0;
        int release2 = 0;
        int hold1 = int.MinValue;
        int hold2 = int.MinValue;
        foreach (var p in prices)
        {
            release2 = Math.Max(release2, hold2 + p);
            hold2 = Math.Max(hold2, release1 - p);
            release1 = Math.Max(release1, hold1 + p);
            hold1 = Math.Max(hold1, -p);
        }
        return release2;
    }

    //public int MaxProfit(int[] prices)
    //{
    //    if (prices.Length < 2)
    //        return 0;
    //    int[,] a = new int[prices.Length, 4];
    //    a[0, 0] = prices[0];//min
    //    a[prices.Length - 1, 2] = prices[prices.Length - 1];// max from right;
    //    for (int i = 1; i < prices.Length; i++)
    //    {
    //        a[i, 1] = Math.Max(prices[i] - a[i - 1, 0], a[i - 1, 1]);
    //        a[i, 0] = Math.Min(a[i - 1, 0], prices[i]);
    //    }
    //    for (int i = prices.Length - 2; i >= 0; i--)
    //    {
    //        a[i, 3] = Math.Max(a[i + 1, 2] - prices[i], a[i + 1, 3]);
    //        a[i, 2] = Math.Max(a[i + 1, 2], prices[i]);
    //    }
    //    var maxValue = a[prices.Length - 1, 1];
    //    for (int i = 1; i < prices.Length - 1; i++)
    //    {
    //        maxValue = Math.Max(maxValue, a[i, 1] + a[i + 1, 3]);
    //    }

    //    return maxValue;
    //}
}