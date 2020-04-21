public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        if (nums.Length == 0) return 0;
        var dict = new Dictionary<int, int>();
        var sum = 0;
        var res = 0;
        dict[0] = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (dict.ContainsKey(sum - k))
                res += dict[sum - k];
            dict[sum] = (dict.ContainsKey(sum) ? dict[sum] : 0) + 1;
        }
        return res;

    }
}
// @lc code=end

