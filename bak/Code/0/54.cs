using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<int> SpiralOrder(int[,] matrix)
    {
        int[,] status = new int[matrix.GetLength(0), matrix.GetLength(1)];
        int i = 0;
        int j = 0;
        List<int> r = new List<int>();
        var stepStauts = 0;
        for (int step = 0; step < matrix.Length; step++)
        {
            r.Add(matrix[i, j]);
            status[i, j] = 1;
            //next step;

            switch (stepStauts)
            {
                case 0: { j++; break; }
                case 1: { i++; break; }
                case 2: { j--; break; }
                default: { i--; break; }
            }
            if (i < 0 || i >= matrix.GetLength(0) || j < 0 || j >= matrix.GetLength(1) || status[i, j] == 1)
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
        return r;
    }

}
