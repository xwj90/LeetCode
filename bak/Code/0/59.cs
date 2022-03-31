using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 59. Spiral Matrix II
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[,] GenerateMatrix(int n)
    {
        int[,] matrix = new int[n,n];
        int i = 0;
        int j = 0;
        List<int> r = new List<int>();
        var stepStauts = 0;
        for (int step = 0; step < n*n; step++)
        {
            matrix[i, j] = step + 1;
            //next step;

            switch (stepStauts)
            {
                case 0: { j++; break; }
                case 1: { i++; break; }
                case 2: { j--; break; }
                default: { i--; break; }
            }
            if (i < 0 || i >= n || j < 0 || j >= n || matrix[i, j] != 0)
            {
                switch (stepStauts)
                {
                    case 0: { j--; i++; stepStauts = 1; break; }
                    case 1: { i--; j--; stepStauts = 2; break; }
                    case 2: { j++; i--; stepStauts = 3; break; }
                    default: { i++; j++; stepStauts = 0; break; }
                }
            }
        }
        return matrix;
    }

}
