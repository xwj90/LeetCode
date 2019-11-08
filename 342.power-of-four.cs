/*
 * @lc app=leetcode id=342 lang=csharp
 *
 * [342] Power of Four
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfFour(int num)
    {
        return num > 0 && ((num & (num - 1)) == 0) && ((num & 0x55555555) == num);
    }
}
// @lc code=end

