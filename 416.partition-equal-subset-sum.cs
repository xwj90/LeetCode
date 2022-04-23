public class Solution
{
    public bool CanPartition(int[] nums)
    {
        var sum = nums.Sum();
        if (sum % 2 == 1) return false;
        var target = nums.Sum() / 2;
        var dp = new int[target + 1];
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = target; j >= nums[i]; j--)
            {
                dp[j] = Math.Max(dp[j], dp[j - nums[i]] + nums[i]);
            }
        }
        return dp[target] == target;
    }
}
// @lc code=end

