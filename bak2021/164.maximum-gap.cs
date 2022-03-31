/*
 * @lc app=leetcode id=164 lang=csharp
 *
 * [164] Maximum Gap
 */

// @lc code=start
public class Solution
{
    public int MaximumGap(int[] nums)
    {
        var a = nums.OrderBy(p => p).ToArray();
        var res = 0;
        for (var i = 1; i < a.Length; i++)
        {
            res = Math.Max(res, a[i] - a[i - 1]);
        }
        return res;
    }
}
// @lc code=end

