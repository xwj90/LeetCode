/*
 * @lc app=leetcode id=349 lang=csharp
 *
 * [349] Intersection of Two Arrays
 */

// @lc code=start
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var res = new HashSet<int>(nums1);
        var res2 = new HashSet<int>();
        foreach (var a in nums2)
        {
            if (res.Contains(a))
            {
                res2.Add(a);
            }
        }
        return res2.ToArray();
    }
}
// @lc code=end

