public class Solution
{
    public int LongestArithSeqLength(int[] A)
    {
        var res = 2;
        var dp = new Dictionary<(int End, int Delta), int>();
        for (var j = 0; j < A.Length; j++)
        {
            for (var i = 0; i < j; i++)
            {
                var delta = A[j] - A[i];
                dp[(j, delta)] = 2;
                if (dp.TryGetValue((i, delta), out var value)) dp[(j, delta)] = value + 1;
                
                res = Math.Max(res, dp[(j, delta)]);
            }
        }
        return res;
    }
}
// @lc code=end

