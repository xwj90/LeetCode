public class Solution
{
    public int MergeStones(int[] stones, int K)
    {
        var n = stones.Length;
        var cost = new int[n, n];
        if ((n - 1) % (K - 1) > 0) return -1;

        var sum = new int[n + 1];
        for (var i = 0; i < n; i++)
            sum[i + 1] = sum[i] + stones[i];

        for (var m = K; m <= n; m++)
        {
            for (var i = 0; i + m <= n; i++)
            {
                var j = i + m - 1;
                cost[i, j] = int.MaxValue;
                for (var mid = i; mid < j; mid += K - 1)
                    cost[i, j] = Math.Min(cost[i, j], cost[i, mid] + cost[mid + 1, j]);
                if ((j - i) % (K - 1) == 0)
                    cost[i, j] += sum[j + 1] - sum[i];
            }
        }
        return cost[0, n - 1];
    }
}
// @lc code=end

