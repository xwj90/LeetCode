/*
 * @lc app=leetcode id=435 lang=csharp
 *
 * [435] Non-overlapping Intervals
 */

// @lc code=start
public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[1] - b[1]);

        int keep = 1;
        int end = intervals[0][1];
        for (var i = 0; i < intervals.Length; i++)
        {
            if (end <= intervals[i][0])
            {
                keep++;
                end = intervals[i][1];
            }
        }
        return intervals.Length - keep;
    }
}
// @lc code=end

