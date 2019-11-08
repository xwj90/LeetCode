using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MinMeetingRooms(Interval[] intervals)
    {
        var starts = intervals.Select(p => p.start).OrderBy(p => p).ToArray();
        var ends = intervals.Select(p => p.end).OrderBy(p => p).ToArray();
        var current = 0;
        var max = 0;
        var endIndex = 0;
        for (int i = 0; i < starts.Length; i++)
        {
            current++;
            while (endIndex < i && ends[endIndex] <= starts[i])
            {
                current--;
                endIndex++;
            }
            max = Math.Max(max, current);
        }
        return max;
    }
}