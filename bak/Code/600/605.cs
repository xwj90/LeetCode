using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var d = flowerbed.ToList();
        d.Insert(0, 0);
        d.Insert(0, 1);
        d.Add(0);
        d.Add(1);
        var max = 0;
        int? start = null;
        for (int i = 0; i < d.Count; i++)
        {
            if (d[i] == 1 && start.HasValue)
            {
                var count = i - start.Value;
                max += (count - 1) / 2;
                start = null;
            }
            if (d[i] == 0 && !start.HasValue)
                start = i;
        }
        return max >= n;
    }


}