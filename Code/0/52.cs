using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    /// <summary>
    /// 52. N-Queens II
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int TotalNQueens(int n)
    {
        int[,] a = new int[n, n];
        int x = 0;
        int y = 0;
        return TotalNQueens_Array(n, a, x, y);
    }

    public int TotalNQueens_Array(int n, int[,] a, int x, int y)
    {
        if (x >= n || y >= n)
            return 0;

        var zero = 0;
        var one = 0;
        var numberOfOne = 0;

        for (int i = 0; i < x; i++)
            numberOfOne += a[i, y];
        for (int i = 0; i < y; i++)
            numberOfOne += a[x, i];

        var id = x + y * n;
        var nextX = (id + 1) % n;
        var nextY = (id + 1) / n;

        if (numberOfOne > 0 || x < n - 1 || y < n - 1)
        {
            a[x, y] = 0;
            zero = TotalNQueens_Array(n, a, nextX, nextY);
        }
        if (numberOfOne == 0)
        {
            a[x, y] = 1;
            one = TotalNQueens_Array(n, a, nextX, nextY);
        }
        return zero + one;
    }

}
