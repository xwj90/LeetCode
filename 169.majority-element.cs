/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var v = int.MinValue;
        var count = 0;
        foreach (var n in nums)
        {
            if (count == 0 || v == n)
            {
                count++;
                v = n;
            }
            else
            {
                count--;
            }
        }

        return v;

    }
}
// @lc code=end

