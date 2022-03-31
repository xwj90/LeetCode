public class Solution
{
    public bool CanJump(int[] nums)
    {
        if (nums.Length == 1) return true;
        if (nums[0] == 0) return false;
        for (var i = 1; i < nums.Length; i++)
        {
            nums[i] = Math.Max(nums[i - 1], i + nums[i]);
            if (nums[i] <= i)
                return false;
            if (nums[i] >= nums.Length - 1)
                return true;
        }
        return true;
    }
}
// @lc code=end

