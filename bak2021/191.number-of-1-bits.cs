/*
 * @lc app=leetcode id=191 lang=csharp
 *
 * [191] Number of 1 Bits
 */

// @lc code=start
public class Solution
{
    public int HammingWeight(uint n)
    {
        int bits = 0;
        int mask = 1;
        for (int i = 0; i < 32; i++)
        {
            if ((n & mask) != 0)
            {
                bits++;
            }
            mask <<= 1;
        }
        return bits;
    }
}
// @lc code=end

