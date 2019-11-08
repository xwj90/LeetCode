using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MaxPoints(Point[] points)
    {
        if (points.Length == 0)
            return 0;
        else if (points.Length == 1)
            return 1;
        decimal v = 1;
        var maxCount = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Dictionary<decimal, int> dict = new Dictionary<decimal, int>();
            var vertical = 0;
            var same = 0;
            var count = 0;
            for (int j = i + 1; j < points.Length; j++)
            {
                if (points[i].x == points[j].x)
                {
                    if (points[i].y == points[j].y)
                        same++;
                    else
                        vertical++;
                }
                else
                {
                    var a = v * (points[i].y - points[j].y) / (points[i].x - points[j].x);
                    var c = 0;
                    if (dict.ContainsKey(a))
                        c = dict[a] + 1;
                    else
                        c = 1;
                    dict[a] = c;
                    count = Math.Max(count, c);
                }
                maxCount = Math.Max(maxCount, Math.Max(count, vertical) + 1 + same);
            }
        }
        return maxCount;
    }
}