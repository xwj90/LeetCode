public class Solution
{
    public int CombinationSum4(int[] nums, int target)
    {
        var dp = new int[target + 1];
        dp[0] = 1;
        for (var i = 0; i <= target; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (i - nums[j] >= 0 && dp[i] < int.MaxValue - dp[i - nums[j]])
                    dp[i] += dp[i - nums[j]];
            }
        }
        return dp[target];
    }
}

