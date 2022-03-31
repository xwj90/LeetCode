public class Solution
{
    public int[] FindRightInterval(int[][] intervals)
    {
        var list = new List<(int start, int id)>();
        for (var i = 0; i < intervals.Length; i++)
        {
            list.Add((intervals[i][0], i));
        }

        list = list.OrderBy(p => p.start).ToList();

        var res = new int[intervals.Length];
        for (var i = 0; i < intervals.Length; i++)
        {
            var idx = list.BinarySearch((intervals[i][1], -1));
            if (idx >= 0) res[i] = list[idx].id;
            else if (~idx >= intervals.Length) res[i] = -1;
            else res[i] = list[~idx].id;
        }
        return res;
    }
}
// @lc code=end

