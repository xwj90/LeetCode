/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        if (x < 10)
            return true;

        long val = x;
        long result = 0;
        while (val > 0)
        {
            var v = val % 10;
            val = val / 10;
            result = result * 10 + v;
        }
        return x == result;
    }
}
// @lc code=end

