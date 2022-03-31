using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public int EraseOverlapIntervals(Interval[] intervals)
    {
        if (intervals.Length == 0) return 0;

        var sort = intervals.OrderBy(p => p.end).ToArray();
        var end = sort[0].end;
        var count = 1;
        for (int i = 1; i < sort.Length; i++)
        {
            if(sort[i].start>=end)
            {
                end = sort[i].end;
                count++;
            }
        }
        return sort.Length - count;
    }
}