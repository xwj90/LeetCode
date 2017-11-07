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
        Dictionary<Tuple<double, double>, int> dict = new Dictionary<Tuple<double, double>, int>();

        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                var a = 0;
                if (points[i].x != points[j].x)
                    a = (points[i].y - points[j].y) / (points[i].x - points[j].x);
                var b = 0;
                if (points[i].y != points[j].y)
                    b = points[i].y - a * points[i].x;
                var key = new Tuple<double, double>(a, b);
                if (dict.ContainsKey(key))
                    dict[key]++;
                else
                    dict[key] = 1;
            }
        }
        var max = 0;
        foreach (var v in dict.Values)
        {
            max = Math.Max(max, v);
        }
        var n1 = (1 + Math.Sqrt(1 + 8 * max)) / 2;
        //var n2 = (1 - Math.Sqrt(1 + 8 * max)) / 2;
        return Convert.ToInt32(n1);// Math.Max(n1, n2));
    }
}