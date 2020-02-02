/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length;
        while (left < right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return left;

    }
}
// @lc code=end

