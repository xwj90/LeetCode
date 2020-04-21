/*
 * @lc app=leetcode id=793 lang=csharp
 *
 * [793] Preimage Size of Factorial Zeroes Function
 */

// @lc code=start
public class Solution
{
    public int PreimageSizeFZF(int K)
    {
//something wrong
        long left = 0;
        long right = int.MaxValue;
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            var zmi = zeta(mid);
            if (zmi == K) return 5;
            else if (zmi < K) left = mid + 1;
            else right = mid;
        }

        return 0;
    }
    public long zeta(long x)
    {
        if (x == 0) return 0;
        return x / 5 + zeta(x / 5);
    }
}
// @lc code=end

