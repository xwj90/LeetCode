public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        int left = intervals[0][0];
        int right = intervals[0][1];
        var res = new List<int[]>();
        for (var i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= right)
            {
                right = Math.Max(right, intervals[i][1]);
            }
            else
            {
                res.Add(new[] { left, right });
                left = intervals[i][0];
                right = intervals[i][1];
            }
        }
        res.Add(new[] { left, right });
        return res.ToArray();
    }
}

