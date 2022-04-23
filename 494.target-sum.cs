public class Solution
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        var sum = nums.Sum();
        if ((sum + target) % 2 != 0) return 0;
        if (Math.Abs(target) > sum) return 0;
        var postiveTarget = (sum + target) / 2;
        var dp = new int[postiveTarget + 1];
        dp[0] = 1;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = postiveTarget; j >= nums[i]; j--)
            {
                dp[j] += dp[j - nums[i]];
            }
        }
        return dp[postiveTarget];
    }
} 