using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public int CoinChange(int[] coins, int amount)
    {
        if (amount == 0)
            return 0;
        int[] a = new int[amount + 1];
        return CoinChange(coins, amount, a);
    }
    public int CoinChange(int[] coins, int amount, int[] a)
    {
        if (a[amount] != 0)
            return a[amount];
        var c = int.MaxValue;

        for (int i = 0; i < coins.Length; i++)
        {
            if (amount == coins[i])
                return 1;
            else if (coins[i] < amount)
            {
                var v = CoinChange(coins, amount - coins[i], a);
                if (v != -1)
                    c = Math.Min(v + 1, c);
            }
        }
        if (c == int.MaxValue)
            c = -1;
        a[amount] = c;
        return c;
    }
}