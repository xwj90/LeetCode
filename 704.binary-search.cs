/*
 * @lc app=leetcode id=704 lang=csharp
 *
 * [704] Binary Search
 */

// @lc code=start
public class Solution
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
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
                right = right - 1;
            }
        }

        return -1;
    }
}
// @lc code=end

