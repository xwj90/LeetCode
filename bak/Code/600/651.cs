using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public int MaxA(int N)
    {
        //var max = N;
        //for (int i = 1; i <= N - 3; i++)
        //    max = Math.Max(max, MaxA(i) * (N - i - 1));
        //return max;
        int[] dp = new int[N + 1];
        for (int i = 0; i <= N; i++)
        {
            dp[i] = i;
            for (int j = 1; j <= i - 3; j++)
                dp[i] = Math.Max(dp[i], dp[j] * (i - j - 1));//make min times=2
        }
        return dp[N];
    }
}