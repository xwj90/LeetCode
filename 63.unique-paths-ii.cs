/*
 * @lc app=leetcode id=63 lang=csharp
 *
 * [63] Unique Paths II
 */

// @lc code=start
public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        var previous = new int[obstacleGrid.Length];
        var current = new int[obstacleGrid.Length];
        var status = 1;
        for (var i = 0; i < obstacleGrid.Length; i++)
        {
            if (obstacleGrid[i][0] == 1)
                status = 0;
            previous[i] = status;
            current[i] = status;
        }

        for (var j = 1; j < obstacleGrid[0].Length; j++)
        {
            for (var i = 0; i < obstacleGrid.Length; i++)
            {
                if (i == 0)
                    current[i] = previous[i];
                else
                    current[i] = previous[i] + current[i - 1];
                if (obstacleGrid[i][j] == 1)
                    current[i] = 0; //reset if it is blocked
            }

            previous = current;
        }
        return current[current.Length - 1];
    }
}
// [[0,0],[1,1],[0,0]]

