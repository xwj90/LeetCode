/*
 * @lc app=leetcode id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution
{
    public double MyPow(double x, int n)
    {
        long N = n;
        if (N < 0)
        {
            x = 1 / x;
            N = -N;
        }
        return fastPow(x, N);
    }
    private double fastPow(double x, long n)
    {
        if (n == 0) return 1;
        var half = fastPow(x, n / 2);
        if (n % 2 == 0)
            return half * half;
        else
            return half * half * x;
    }
}
// @lc code=end

