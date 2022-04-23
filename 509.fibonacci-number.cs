/*
 * @lc app=leetcode id=509 lang=csharp
 *
 * [509] Fibonacci Number
 */

// @lc code=start
public class Solution
{
    public int Fib(int n)
    {
        if (n <= 1) return n;
        var d1 = 1;
        var d2 = 0;
        var sum = 0;
        for (var i = 2; i <= n; i++)
        {
            sum = d1 + d2;
            d2 = d1;
            d1 = sum;
        }
        return sum;
    }
}
// @lc code=end

