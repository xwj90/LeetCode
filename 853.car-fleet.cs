/*
 * @lc app=leetcode id=853 lang=csharp
 *
 * [853] Car Fleet
 */

// @lc code=start
public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        if (position.Length == 0) return 0;

        var arr = new List<(int pos, double time)>();
        for (var i = 0; i < position.Length; i++)
        {
            arr.Add((position[i], (target - position[i] + 0.0) / speed[i]));
        }
        arr = arr.OrderByDescending(p => p.pos).ToList();
        var res = 0;
        for (var i = 1; i < arr.Count; i++)
        {
            if (arr[i].time > arr[i - 1].time) res++;
            else arr[i] = (arr[i].pos, arr[i - 1].time);
        }
        return res + 1;

    }
}
// @lc code=end

