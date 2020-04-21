/*
 * @lc app=leetcode id=201 lang=csharp
 *
 * [201] Bitwise AND of Numbers Range
 */

// @lc code=start
public class Solution
{
    public int RangeBitwiseAnd(int m, int n)
    {
        int shift = 0;
        while (m < n)
        {
            n >>= 1;
            n >>= 1;
            ++shift;
        }
        return m << shift;
    }
}
// @lc code=end

