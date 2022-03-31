public class Solution
{
    public int MaxEvents(int[][] events)
    {
        events = events.OrderBy(p => p[0]).ThenBy(p => p[1]).ToArray();
        var ss = new SortedSet<(int end, int id)>();
        var i = 0;
        var res = 0;
        for (var d = 1; d <= 100000; ++d)
        {
            while (i < events.Length && events[i][0] == d)
            {
                ss.Add((events[i++][1], i));
            }
            while (ss.Any() && ss.Min.end < d)
            {
                ss.Remove(ss.Min);
            }
            if (ss.Any())
            {
                ss.Remove(ss.Min);
                ++res;
            }
        }
        return res;
    }

}
// @lc code=end

