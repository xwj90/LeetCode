public class Solution
{
    public int[] MaxSumOfThreeSubarrays(int[] nums, int K)
    {
        var W = new int[nums.Length - K + 1];
        var sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (i >= K) sum -= nums[i - K];
            if (i >= K - 1) W[i - K + 1] = sum;
        }

        var left = new int[W.Length];
        int best = 0;
        for (var i = 0; i < W.Length; i++)
        {
            if (W[i] > W[best]) best = i;
            left[i] = best;
        }


        var right = new int[W.Length];
        best = W.Length - 1;
        for (int i = W.Length - 1; i >= 0; i--)
        {
            if (W[i] >= W[best]) best = i;
            right[i] = best;
        }

        int[] ans = new int[] { -1, -1, -1 };
        for (int j = K; j < W.Length - K; j++)
        {
            var i = left[j - K];
            var k = right[j + K];
            if (ans[0] == -1 || W[i] + W[j] + W[k] >
                    W[ans[0]] + W[ans[1]] + W[ans[2]])
            {

                ans[0] = i;
                ans[1] = j;
                ans[2] = k;
            }
        }
        return ans;
    }
}
// @lc code=end

