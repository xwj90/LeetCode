using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool SearchMatrix(int[,] matrix, int target)
    {
        var l = matrix.GetLength(1);
        var left = 0;
        var right = matrix.Length - 1;
        var mid = 0;
        while (left <= right)
        {
            mid = (left + right) / 2;
            var i = mid / l;
            var j = mid % l;
            if (matrix[i, j] == target)
                return true;
            else if (matrix[i, j] > target)
                right = mid - 1;
            else
                left = mid + 1;
        }
        return false;
    }
}
