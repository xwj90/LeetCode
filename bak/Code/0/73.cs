using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public void SetZeroes(int[,] matrix)
    {
        var row0 = false;
        var col0 = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
            row0 = row0 == true ? true : matrix[i, 0] == 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            col0 = col0 == true ? true : matrix[0, j] == 0;
        for (int i = 1; i < matrix.GetLength(0); i++)
            for (int j = 1; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == 0)
                {
                    matrix[i, 0] = 0;
                    matrix[0, j] = 0;
                }

        for (int i = 1; i < matrix.GetLength(0); i++)
            if (matrix[i, 0] == 0)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = 0;

        for (int j = 1; j < matrix.GetLength(1); j++)
            if (matrix[0, j] == 0)
                for (int i = 0; i < matrix.GetLength(0); i++)
                    matrix[i, j] = 0;
        if (row0)
            for (int i = 0; i < matrix.GetLength(0); i++)
                matrix[i, 0] = 0;
        if (col0)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[0, j] = 0;

    }

}
