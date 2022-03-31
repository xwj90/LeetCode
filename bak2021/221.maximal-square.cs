public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0) return 0;

        var x = matrix.Length;
        var y = matrix[0].Length;
        var max = 0;
        var dp = new int[x + 1, y + 1];
        for (var i = 1; i <= x; i++)
            for (var j = 1; j <= y; j++)
            {
                if (matrix[i - 1][j - 1] == '1')
                {
                    dp[i, j] = Math.Min(Math.Min(dp[i, j - 1], dp[i - 1, j]), dp[i - 1, j - 1]) + 1;
                    max = Math.Max(max, dp[i, j] * dp[i, j]);
                }
            }

        return max;
    }
}
// @lc code=end

