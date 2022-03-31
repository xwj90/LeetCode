using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{


    /// <summary>
    ///  
    /// 
    /// </summary>
    /// <param name="numRows"></param>
    /// <returns></returns>
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>();
        for (int i = 0; i < numRows; i++)
        {
            var v = new int[i + 1];
            v[0] = 1;
            v[v.Length - 1] = 1;
            for (int j = 1; j <= i / 2; j++)
            {
                v[j] = result[i - 1][j - 1] + result[i - 1][j];
                v[v.Length - j - 1] = v[j];
            }
            result.Add(v.ToList());
        }
        return result;



    }
}