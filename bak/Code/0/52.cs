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
        return TotalNQueens_Count(0, n);
    }
    private HashSet<int> occupiedY = new HashSet<int>();
    private HashSet<int> occupiedDiagnal1 = new HashSet<int>();
    private HashSet<int> occupiedDiagnal2 = new HashSet<int>();
    private int TotalNQueens_Count(int row, int n)
    {
        var positions = 0;
        for (int col = 0; col < n; col++)
        {
            if (occupiedY.Contains(col)) continue; //we found one in this column
            if (occupiedDiagnal1.Contains(row - col)) continue;
            if (occupiedDiagnal2.Contains(row + col)) continue;
            if (row == n - 1)
                positions++;
            else
            {
                occupiedY.Add(col);
                occupiedDiagnal1.Add(row - col);
                occupiedDiagnal2.Add(row + col);
                positions += TotalNQueens_Count(row + 1, n);
                occupiedY.Remove(col);
                occupiedDiagnal1.Remove(row - col);
                occupiedDiagnal2.Remove(row + col);
            }
        }
        return positions;
    }
}
