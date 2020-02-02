/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start
public class Solution
{
    Dictionary<int, int> cache = new Dictionary<int, int>();
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;
        if (cache.ContainsKey(n)) return cache[n];
        var step = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        cache[n] = step;
        return step;
    }
}
// @lc code=end

