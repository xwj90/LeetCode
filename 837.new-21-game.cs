public class Solution
{
    public double New21Game(int N, int K, int W)
    {
        var dp = new double[N + W + 1];
        // dp[x] = the answer when Alice has x points
        for (int k = K; k <= N; ++k)
            dp[k] = 1.0;

        double S = Math.Min(N - K + 1, W);
        // S = dp[k+1] + dp[k+2] + ... + dp[k+W]
        for (int k = K - 1; k >= 0; --k)
        {
            dp[k] = S / W;
            S += dp[k] - dp[k + W];
        }
        return dp[0];
    }
}
// @lc code=end

