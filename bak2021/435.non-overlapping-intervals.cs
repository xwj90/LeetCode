public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        if (intervals.Length == 0) return 0;
        intervals = intervals.OrderBy(p => p[0]).ToArray();
        var dp = new int[intervals.Length];
        dp[0] = 1;
        var ans = 1;
        for (var i = 1; i < dp.Length; i++)
        {
            var max = 0;
            for (var j = i - 1; j >= 0; j--)
            {
                if (intervals[j][1] <= intervals[i][0])
                    max = Math.Max(dp[j], max);
            }
            dp[i] = max + 1;
            ans = Math.Max(ans, dp[i]);
        }
        return intervals.Length - ans;
    }
}
// @lc code=end

