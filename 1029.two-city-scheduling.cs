/*
 * @lc app=leetcode id=1029 lang=csharp
 *
 * [1029] Two City Scheduling
 */

// @lc code=start
public class Solution
{
    public int TwoCitySchedCost(int[][] costs)
    {
        var diff = new List<(int, int)>();
        for (var i = 0; i < costs.Length; i++)
        {
            diff.Add( (i, costs[i][0] - costs[i][1]));
        }
        var orderedDiff = diff.OrderBy(p => p.Item2).ToList();
        var sum = 0;
        for (var i = 0; i < diff.Count; i++)
        {
            if (i < diff.Count / 2)
            {
                sum += costs[orderedDiff[i].Item1][0];
            }
            else
            {
                sum += costs[orderedDiff[i].Item1][1];
            }
        }
        return sum;
    }
}
// @lc code=end

