using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 77. Combinations
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public IList<IList<int>> Combine(int n, int k)
    {
        return Combine(n, k, 0);
    }
    private IList<IList<int>> Combine(int n, int k, int v)
    {
        var result = new List<IList<int>>();
        for (int i = v + 1; i <= n; i++)
            if (k > 1)
            {
                var ls = Combine(n, k - 1, i);
                foreach (var item in ls)
                {
                    var temp = new List<int>(item);
                    temp.Add(i);
                    result.Add(temp);
                }
            }
            else
            {
                result.Add(new List<int>() { i });
            }
        return result;
    }
}
