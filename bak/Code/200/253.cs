using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool CanAttendMeetings(Interval[] intervals)
    {
        if (intervals == null || intervals.Length <= 1)
            return true;
        var sort = intervals.OrderBy(p => p.start).ToArray();
        for (int i = 1; i < sort.Length; i++)
            if (sort[i].start < sort[i - 1].end)
                return false;
        
        return true;

    }
}