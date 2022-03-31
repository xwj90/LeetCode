/*
 * @lc app=leetcode id=275 lang=csharp
 *
 * [275] H-Index II
 */

// @lc code=start
public class Solution
{
    public int HIndex(int[] citations)
    {
        var left = 0;
        var right = citations.Length - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (citations[mid] >= (citations.Length - mid)) right = mid - 1;
            else left = mid + 1;
        }
        return citations.Length - left;
    }
}
// @lc code=end

