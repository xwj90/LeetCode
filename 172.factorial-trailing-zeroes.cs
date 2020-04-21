/*
 * @lc app=leetcode id=172 lang=csharp
 *
 * [172] Factorial Trailing Zeroes
 */

// @lc code=start
public class Solution
{
    public int TrailingZeroes(int n)
    {
        return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
    }
}
// @lc code=end

