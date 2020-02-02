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
        return UniquePathsCount(1, 1, obstacleGrid.Length, obstacleGrid[0].Length, obstacleGrid);
    }


    Dictionary<(int, int), int> dict = new Dictionary<(int, int), int>();
    public int UniquePathsCount(int x, int y, int m, int n, int[][] obstacleGrid)
    {
        if (obstacleGrid[x - 1][y - 1] == 1) return 0;
        if (x == m && y == n) return 1;
        if (dict.ContainsKey((x, y))) return dict[(x, y)];
        var count = 0;
        if (x < m) count += UniquePathsCount(x + 1, y, m, n, obstacleGrid);
        if (y < n) count += UniquePathsCount(x, y + 1, m, n, obstacleGrid);
        dict[(x, y)] = count;
        return count;
    }
}
// @lc code=end

