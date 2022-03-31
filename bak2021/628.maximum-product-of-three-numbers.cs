/*
 * @lc app=leetcode id=628 lang=csharp
 *
 * [628] Maximum Product of Three Numbers
 */

// @lc code=start
public class Solution
{
    public int MaximumProduct(int[] nums)
    {
        var max1 = int.MinValue;
        var max2 = int.MinValue;
        var max3 = int.MinValue;
        var min1 = int.MaxValue;
        var min2 = int.MaxValue;
        foreach (var n in nums)
        {
            if (n > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = n;
            }
            else if (n > max2)
            {
                max3 = max2;
                max2 = n;
            }
            else if (n > max3)
            {
                max3 = n;
            }
            if (n < min1)
            {
                min2 = min1;
                min1 = n;
            }
            else if (n < min2)
            {
                min2 = n;
            }            
        }
        return Math.Max(max1 * max2 * max3, max1 * min1 * min2);
    }
}
// @lc code=end

