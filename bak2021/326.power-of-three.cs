/*
 * @lc app=leetcode id=326 lang=csharp
 *
 * [326] Power of Three
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n < 1) return false;
        else if (n == 1) return true;
        long current = 3;

        while (n % 3 == 0)
        {
            n /= 3;
        }

        return n == 1;
    }
}
// @lc code=end

