/*
 * @lc app=leetcode id=633 lang=csharp
 *
 * [633] Sum of Square Numbers
 */

// @lc code=start
public class Solution
{
    public bool JudgeSquareSum(int c)
    {
        for (long a = 0; a * a <= c; a++)
        {
            var b = Math.Sqrt(c - a * a);
            if (b == (int)b) return true;
        }
        return false;

    }
}
// @lc code=end

