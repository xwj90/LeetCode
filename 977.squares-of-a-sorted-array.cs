/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 */

// @lc code=start
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        var results = new int[nums.Length];
        var current = right;

        while (left <= right)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                results[current--] = nums[left] * nums[left];
                left++;
            }
            else
            {
                results[current--] = nums[right] * nums[right];
                right--;
            }
        }


        return results;

    }
}
// @lc code=end

