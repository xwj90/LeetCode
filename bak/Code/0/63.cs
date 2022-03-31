using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    /// <summary>
    /// 63. Unique Paths II
    /// </summary>
    /// <param name="obstacleGrid"></param>
    /// <returns></returns>
    public int UniquePathsWithObstacles(int[,] obstacleGrid)
    {
        var dp = new int[obstacleGrid.GetLength(0)];
        dp[0] = 1;
        for (int j = 0; j < obstacleGrid.GetLength(1); j++)
            for (int i = 0; i < obstacleGrid.GetLength(0); i++)
                if (obstacleGrid[i, j] == 1)
                    dp[i] = 0;
                else if (i > 0)
                    dp[i] += dp[i - 1];

        return dp[obstacleGrid.GetLength(0) - 1];

    }
}
