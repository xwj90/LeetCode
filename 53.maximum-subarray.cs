/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        var result = int.MinValue;
        int current = 0;
        foreach (var v in nums)
        {
            current += v;
            result = Math.Max(result, current);
            current = Math.Max(0, current);
        }
        return result;
    }
}
// @lc code=end

