/*
 * @lc app=leetcode id=554 lang=csharp
 *
 * [554] Brick Wall
 */

// @lc code=start
public class Solution
{
    public int LeastBricks(IList<IList<int>> wall)
    {
        var dict = new Dictionary<int, int>();
        foreach (var list in wall)
        {
            var sum = 0;
            for (var i = 0; i < list.Count - 1; i++)
            {
                sum += list[i];
                if (!dict.ContainsKey(sum)) dict[sum] = 1;
                else dict[sum] += 1;
            }
        }
        if (!dict.Any()) return wall.Count;
        var max = dict.Max(p => p.Value);
        return wall.Count - max;
    }
}
// @lc code=end

