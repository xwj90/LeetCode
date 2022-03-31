using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
    {
        //quick sort by start
        List<Interval> list = new List<Interval>();
        List<Interval> list2 = new List<Interval>();
        var min = newInterval.start ;
        var max = newInterval.end;
        foreach (var item in intervals)
        {
            if (item.start > newInterval.end)
                list2.Add(item);
            else if (item.end < newInterval.start)
                list.Add(item);
            else
            {
                min = Math.Min(item.start, min);
                max = Math.Max(item.end, max);
            }
        }
        list.Add(new Interval(min, max));
        list.AddRange(list2);
        return list;
    }


}
