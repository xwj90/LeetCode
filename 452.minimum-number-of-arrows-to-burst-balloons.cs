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
        var sort = points.OrderBy(p => p[0]);

        var count = 0;
        int? right = null;
        foreach (var point in sort)
        {
            if (!right.HasValue)
            {
                count++;
                right = point[1];
            }
            else
            {
                if (right.Value < point[0])
                {
                    count++;
                    right = point[1];
                }
                else
                {
                    right = Math.Min(right.Value, point[1]);
                }
            }
        }



        return count;
    }
}
// @lc code=end

