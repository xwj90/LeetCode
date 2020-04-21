/*
 * @lc app=leetcode id=29 lang=csharp
 *
 * [29] Divide Two Integers
 */

// @lc code=start
public class Solution
{
    public int Divide(int dividend, int divisor)
    {
       if (divisor == 0 || (dividend == int.MinValue && divisor == -1))
            return int.MaxValue;
        int sign = (dividend < 0) ^ (divisor < 0) ? -1 : 1;
        long d1 = Math.Abs((long)dividend);
        long d2 = Math.Abs((long)divisor);
        long r = 0;
        while (d1 >= d2)
        {
            long temp = d2, muliple = 1;
            while (d1 >= (temp << 1))
            {
                temp <<= 1;
                muliple <<= 1;
            }
            d1 -= temp;
            r += muliple;
        }
        return Convert.ToInt32(sign * r);
    }
}
// @lc code=end

