using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<Interval> Merge(IList<Interval> intervals)
    {
        if (intervals.Count == 1)
            return intervals;
        var sort = intervals.OrderBy(p => p.start).ToList();
        for (int i = 0; i < sort.Count - 1; i++)
        {
            if (sort[i].end >= sort[i + 1].start)
            {
                sort[i].end = Math.Max(sort[i + 1].end, sort[i].end);
                sort.RemoveAt(i + 1);
                i--;
            }
        }
        return sort;
    }
}
