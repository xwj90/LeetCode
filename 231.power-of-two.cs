/*
 * @lc app=leetcode id=231 lang=csharp
 *
 * [231] Power of Two
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        long res = 1;
        while (res <= n)
        {
            if (res == n) return true;
            res <<= 1;
        }

        return false;
    }
}
// @lc code=end

