/*
 * @lc app=leetcode id=64 lang=csharp
 *
 * [64] Minimum Path Sum
 */

// @lc code=start
public class Solution
{
    public int MinPathSum(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        for (var i = 1; i < m; i++)
            grid[i][0] += grid[i - 1][0];
        for (var j = 1; j < n; j++)
            grid[0][j] += grid[0][j - 1];
        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                var top = grid[i][j] + grid[i - 1][j];
                grid[i][j] += grid[i][j - 1];
                grid[i][j] = Math.Min(top, grid[i][j]);
            }
        }
        return grid[m - 1][n - 1];
    }
}
// @lc code=end

