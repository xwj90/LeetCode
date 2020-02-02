public class Solution
{
    public void SortColors(int[] nums)
    {
        var j = 0;
        var k = nums.Length - 1;
        for (var i = 0; i <= k; i++)
        {
            if (nums[i] == 0)
                swap(nums, i, j++);
            else if (nums[i] == 2)
                swap(nums, i--, k--);
        }

    }
    private void swap(int[] nums, int i, int j)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
// @lc code=end

