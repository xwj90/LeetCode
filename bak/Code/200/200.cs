using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int NumIslands(char[,] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.GetLength(0); i++)
            for (int j = 0; j < grid.GetLength(1); j++)
                count += NumIslands_Set(grid, i, j);
        return count;
    }
    int NumIslands_Set(char[,] grid, int i, int j)
    {
        if (i >= 0 && j >= 0 && i < grid.GetLength(0) && j < grid.GetLength(1) && grid[i, j] == '1')
        {
            grid[i, j] = '0';
            NumIslands_Set(grid, i + 1, j);
            NumIslands_Set(grid, i - 1, j);
            NumIslands_Set(grid, i, j + 1);
            NumIslands_Set(grid, i, j - 1);
            return 1;
        }
        return 0;
    }

}