public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        var count = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                count++;
            else
                nums[i - count] = nums[i];
        }
        return nums.Length - count;

    }
}
// @lc code=end

