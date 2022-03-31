public class Solution
{
    public int WiggleMaxLength(int[] nums)
    {
        if (nums.Length < 2)
            return nums.Length;

        var down = 1;
        var up = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                up = down + 1;
            }
            else if (nums[i] < nums[i - 1])
            {
                down = up + 1;
            }
        }
        return Math.Max(down, up);
    }
}
// @lc code=end

