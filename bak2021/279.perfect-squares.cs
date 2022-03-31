public class Solution
{
    public int NumSquares(int n)
    {
        if (n <= 0) return 0;

        var count = new long[n + 1];
        for (var i = 1; i < count.Length; i++)
            count[i] = int.MaxValue;
        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j * j <= i; j++)
            {
                count[i] = Math.Min(count[i], count[i - j * j] + 1);
            }
        }
        return (int)count[n];
    }
}
// @lc code=end

