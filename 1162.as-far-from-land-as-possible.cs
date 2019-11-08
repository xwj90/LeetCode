/*
 * @lc app=leetcode id=1162 lang=csharp
 *
 * [1162] As Far from Land as Possible
 */
public class Solution
{
    private void Loop(int[][] grid, Action<int, int> a)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                a(i, j);
            }
        }
    }
    private void Check(int i, int j, int[][] grid, int v, HashSet<(int, int)> hs)
    {
        if (i >= 0 && i < grid.Length)
        {
            if (j >= 0 && j < grid[i].Length)
            {
                if (grid[i][j] == 0)
                {
                    grid[i][j] = v + 1;
                    hs.Add((i, j));
                }
                else if (grid[i][j] > 1)
                {
                    grid[i][j] = Math.Min(grid[i][j], v + 1);
                }
            }
        }
    }
    public int MaxDistance(int[][] grid)
    {
        HashSet<(int, int)> hs = new HashSet<(int, int)>();
        Loop(grid, (i, j) =>
        {
            if (grid[i][j] == 1)
            {
                hs.Add((i, j));
            }
        });
        while (hs.Any())
        {
            HashSet<(int, int)> hs2 = new HashSet<(int, int)>();
            foreach (var (i, j) in hs)
            {
                Check(i - 1, j, grid, grid[i][j], hs2);
                Check(i, j - 1, grid, grid[i][j], hs2);
                Check(i + 1, j, grid, grid[i][j], hs2);
                Check(i, j + 1, grid, grid[i][j], hs2);
            }
            hs = hs2;
        }

        var max = grid.Max(line => line.Max());
        if (max <= 1)
            return -1;
        return max - 1;
    }
}

