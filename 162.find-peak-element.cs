/*
 * @lc app=leetcode id=162 lang=csharp
 *
 * [162] Find Peak Element
 */

// @lc code=start
public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        var l = 0;
        var r = nums.Length - 1;
        while (l < r)
        {
            var mid = (l + r) / 2;
            if (nums[mid] > nums[mid + 1])
                r = mid;
            else
                l = mid + 1;
        }
        return l;

    }
}
// @lc code=end

