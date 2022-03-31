using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        var minPath = new Dictionary<Tuple<int, int>, int>();
        return MinimumTotal(triangle, 0, 0, minPath);
    }

    private int MinimumTotal(IList<IList<int>> triangle, int x, int y, Dictionary<Tuple<int, int>, int> minPath)
    {
        var key = new Tuple<int, int>(x, y);
        if (minPath.ContainsKey(key))
            return minPath[key];
        var d = triangle[x][y];
        if (x < triangle.Count - 1)
            d += Math.Min(MinimumTotal(triangle, x + 1, y, minPath), MinimumTotal(triangle, x + 1, y + 1, minPath));
        minPath[key] = d;
        return d;
    }
}