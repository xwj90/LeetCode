using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public int MinPathSum(int[,] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
            for (int j = 0; j < grid.GetLength(1); j++)
                if (i == 0 && j == 0) { }
                else if (i == 0 && j != 0) grid[i, j] += grid[i, j - 1];
                else if (i != 0 && j == 0) grid[i, j] += grid[i - 1, j];
                else grid[i, j] += Math.Min(grid[i - 1, j], grid[i, j - 1]);

        return grid[grid.GetLength(0) - 1, grid.GetLength(1) - 1];
    }
}
