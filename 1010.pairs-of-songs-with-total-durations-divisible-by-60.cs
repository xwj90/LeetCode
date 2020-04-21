/*
 * @lc app=leetcode id=1010 lang=csharp
 *
 * [1010] Pairs of Songs With Total Durations Divisible by 60
 */

// @lc code=start
public class Solution
{
    public int NumPairsDivisibleBy60(int[] time)
    {
        var res = 0;
        var c = new int[60];
        foreach (var t in time)
        {
            res += c[(600 - t) % 60];
            c[t % 60]++;
        }
        return res;
    }
}
// @lc code=end

