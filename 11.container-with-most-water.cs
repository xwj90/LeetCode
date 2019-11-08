/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
public class Solution
{
    public int MaxArea(int[] height)
    {
        var max = 0;
        var l = 0;
        var r = height.Length - 1;
        while (l < r)
        {
            max = Math.Max(max, Math.Min(height[l], height[r]) * (r - l));
            if (height[l] < height[r])
                l++;
            else
                r--;
        }
        return max;
    }
}
// @lc code=end

