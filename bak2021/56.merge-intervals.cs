public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals == null || intervals.Length <= 1)
            return intervals;

        intervals = intervals.OrderBy(p => p[0]).ToArray();
        var current = intervals[0];
        var list = new List<int[]>();
        for (var i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= current[1])
            {
                current[1] = Math.Max(current[1], intervals[i][1]);
            }
            else
            {
                list.Add(current);
                current = intervals[i];
            }
        }
        list.Add(current);
        return list.ToArray();
    }
}
// @lc code=end

