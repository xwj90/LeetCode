/*
 * @lc app=leetcode id=461 lang=csharp
 *
 * [461] Hamming Distance
 */

// @lc code=start
public class Solution
{
    public int HammingDistance(int x, int y)
    {
        var d = 0;
        while (x > 0 || y > 0)
        {
            var x1 = x % 2;
            var y1 = y % 2;
            if (x1 != y1) d++;
            x = x / 2;
            y = y / 2;
        }
        return d;

    }
}
// @lc code=end

