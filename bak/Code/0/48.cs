using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public void Rotate(int[,] matrix)
    {
        var l = matrix.GetLength(0);
        for (int i = 0; i < l; i++)
        {
            for (int j = 0 + i; j < l - i - 1; j++)
            {
                var temp = matrix[i, j];
                matrix[i, j] = matrix[Math.Abs(l - 1 - j), i];
                matrix[Math.Abs(l - 1 - j), i] = matrix[Math.Abs(l - 1 - i), Math.Abs(l - 1 - j)];
                matrix[Math.Abs(l - 1 - i), Math.Abs(l - 1 - j)] = matrix[j, Math.Abs(l - 1 - i)];
                matrix[j, Math.Abs(l - 1 - i)] = temp;
            }
        }
    }
}
