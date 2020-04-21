/*
 * @lc app=leetcode id=452 lang=csharp
 *
 * [452] Minimum Number of Arrows to Burst Balloons
 */

// @lc code=start
public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {

        var data = points.OrderBy(p => p[0]).ThenBy(p => p[1]).ToArray();
        var max = long.MaxValue;
        var res = 0;
        foreach (var point in data)
        {
            if (point[0] <= max)
            {
                max = Math.Min(max, point[1]);
            }
            else
            {
                res++;
                max = point[1];
            }
        }
        if (max != long.MaxValue) res++;
        return res;

    }
}
// @lc code=end

