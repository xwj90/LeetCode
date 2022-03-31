/*
 * @lc app=leetcode id=367 lang=csharp
 *
 * [367] Valid Perfect Square
 */

// @lc code=start
public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        long min = 0;
        long max = num;

        while (min <= max)
        {
            var mid = min + (max - min) / 2;
            var mid_2 = mid * mid;
            if (mid_2 == num)
            {
                return true;
            }
            else if (mid_2 > num)
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return false;

    }
}
// @lc code=end

