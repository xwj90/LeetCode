/*
 * @lc app=leetcode id=204 lang=csharp
 *
 * [204] Count Primes
 */

// @lc code=start
public class Solution
{
    public int CountPrimes(int n)
    {
        var status = new bool[n];
        var count = 0;
        for (var i = 2; i < n; i++)
        {
            if (!status[i]) count++;
            for (var j = 2; i * j < n; j++)
                status[i * j] = true;
        }
        return count;
    }
}
// @lc code=end

