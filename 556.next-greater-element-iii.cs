using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public int NextGreaterElement(int n)
    {
        var c = n.ToString().ToCharArray().Select(p => Convert.ToInt32(p.ToString())).ToArray();
        var max = int.MinValue;
        var min = int.MaxValue;
        var minId = -1;
        for (int i = c.Length - 1; i >= 0; i--)
        {
            var v = c[i];
            max = Math.Max(max, v);
            if (v < max)
            {
                for (int j = i + 1; j < c.Length; j++)
                {
                    if (c[j] < min && c[j] > v)
                    {
                        minId = j;
                        min = c[j];
                    }
                }
                c[i] = c[minId];
                c[minId] = v;
                Array.Sort(c, i + 1, c.Length - i - 1);
                double result = 0;
                for (int j = 0; j < c.Length; j++)
                {
                    result += (c[c.Length - 1 - j]) * Math.Pow(10, j);
                }
                if (result > int.MaxValue)
                    return -1;
                return Convert.ToInt32(result);
            }
        }
        return -1;
    }
}