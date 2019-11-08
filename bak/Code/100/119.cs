using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public IList<int> GetRow(int rowIndex)
    {
        if (rowIndex == 0)
            return new List<int>() { 1 };
        else
            return GetRow(rowIndex + 1, 1, new List<int>() { 1 });
    }
    private IList<int> GetRow(int rowIndex, int currentRowId, IList<int> previousRow)
    {
        var v = new int[currentRowId];
        v[0] = 1;
        v[v.Length - 1] = 1;
        for (int j = 1; j <= (currentRowId - 1) / 2; j++)
        {
            v[j] = previousRow[j - 1] + previousRow[j];
            v[v.Length - j - 1] = v[j];
        }
        if (rowIndex == currentRowId)
            return v;
        else
            return GetRow(rowIndex, currentRowId + 1, v);
    }
}