public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        var max = nums[0];
        var pre = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (pre > 0) pre += nums[i];
            else pre = nums[i];
            max = Math.Max(pre, max);
        }
        return max;
    }
    // private Dictionary<(int, int), int> dict = new Dictionary<(int, int), int>();
    // private int MaxSubArray(int[] nums, int left, int right, int currentSum)
    // {
    //     var key = (left, right);
    //     if (dict.ContainsKey(key))
    //         return dict[key];
    //     if (left == right)
    //         return nums[left];        
    //     var missLeft = MaxSubArray(nums, left + 1, right, currentSum - nums[left]);
    //     var missRight = MaxSubArray(nums, left, right - 1, currentSum - nums[right]);
    //     var max = Math.Max(currentSum, Math.Max(missLeft, missRight));
    //     dict[key] = max;
    //     return max;
    // }
}
// @lc code=end

