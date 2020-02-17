/*
 * @lc app=leetcode id=1094 lang=csharp
 *
 * [1094] Car Pooling
 */

// @lc code=start
public class Solution
{
    public bool CarPooling(int[][] trips, int capacity)
    {
        var list = new List<(int Id, bool IsAdd, int Num)>();
        foreach (var trip in trips)
        {
            list.Add((trip[1], true, trip[0]));
            list.Add((trip[2], false, trip[0]));
        }

        var cap = 0;
        foreach (var change in list.OrderBy(p => p.Id).ThenBy(p => p.IsAdd))
        {
            if (change.IsAdd) cap += change.Num;
            else cap -= change.Num;
            if (cap > capacity) return false;
        }
        return true;

    }
}
// @lc code=end

