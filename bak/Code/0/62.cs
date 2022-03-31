using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public int UniquePaths(int m, int n)
    {
        var dp = new int[m];
        dp[0] = 1;
        for (int j = 0; j < n; j++)
            for (int i = 1; i < m; i++)
                dp[i] += dp[i - 1];

        return dp[m - 1];
    }


}
