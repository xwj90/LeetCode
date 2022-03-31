/*
 * @lc app=leetcode id=1227 lang=csharp
 *
 * [1227] Airplane Seat Assignment Probability
 */

// @lc code=start
public class Solution
{
    public double NthPersonGetsNthSeat(int n)
    {
        // f(n)
        // = 1/n + 0 + 1/n * (f(n-1) + f(n-2) + ... + f(2))
        // = 1/n * (f(n-1) + f(n-2) + ... + f(2) + 1)
        // = 1/n * (f(n-1) + f(n-2) + ... + f(2) + f(1))

        // f(n-1) = 1/(n-1) * (f(n-2) + f(n-3) + ... + f(1))

        // n * f(n) = f(n-1) + f(n-2) + f(n-3) + ... + f(1)
        // (n-1) * f(n-1) = f(n-2) + f(n-3) + ... + f(1)

        // n * f(n) - (n-1)*f(n-1) = f(n-1)

        // f(n) = f(n - 1)
        if (n == 1) return 1.0d;
        return 0.5;
    }
}
// @lc code=end

