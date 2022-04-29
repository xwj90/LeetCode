/*
 * @lc app=leetcode id=189 lang=csharp
 *
 * [189] Rotate Array
 */

// @lc code=start
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n;
        reverse(nums, 0, n - 1);
        reverse(nums, 0, k - 1);
        reverse(nums, k, n - 1);

    }

    private void reverse(int[] nums, int start, int end)
    {
        for (int i = start, j = end; i < j; i++, j--)
        {
            int temp = nums[j];
            nums[j] = nums[i];
            nums[i] = temp;
        }
    }
}
// @lc code=end

