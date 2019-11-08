/*
 * @lc app=leetcode id=621 lang=csharp
 *
 * [621] Task Scheduler
 */

// @lc code=start
public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        var map = new int[26];
        foreach (var c in tasks)
            map[c - 'A']++;
        map = map.OrderBy(p => p).ToArray();
        int max_val = map[25] - 1;
        var idle_slots = max_val * n;
        for (var i = 24; i >= 0 && map[i] > 0; i--)
        {
            idle_slots -= Math.Min(map[i], max_val);
        }
        return idle_slots > 0 ? idle_slots + tasks.Length : tasks.Length;
    }
}
// @lc code=end

