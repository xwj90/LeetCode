/*
 * @lc app=leetcode id=724 lang=csharp
 *
 * [724] Find Pivot Index
 */

// @lc code=start
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var sum = nums.Sum();
        var leftSum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (leftSum == sum - nums[i] - leftSum)
                return i;
            leftSum += nums[i];
        }
        return -1;

    }
}
// @lc code=end

