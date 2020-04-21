/*
 * @lc app=leetcode id=476 lang=csharp
 *
 * [476] Number Complement
 */

// @lc code=start
public class Solution
{
    public int FindComplement(int num)
    {
        int n = 0;
        while (n < num)
        {
            n = (n << 1) | 1;
        }
        return n - num;
    }
}
// @lc code=end

