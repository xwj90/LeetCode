public class Solution
{
    public int MinSubArrayLen(int s, int[] nums)
    {
        var l = 0;
        var sum = 0;
        var min = int.MaxValue;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            while (sum >= s)
            {
                min = Math.Min(min, i - l + 1);
                sum -= nums[l++];
            }
        }
        return int.MaxValue == min ? 0 : min;

    }
}
// @lc code=end

