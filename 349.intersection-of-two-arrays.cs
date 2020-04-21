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
        var hs1 = new HashSet<int>(); 
        var hs2 = new HashSet<int>(); 
        foreach (var n in nums1)
            hs1.Add(n);
        foreach (var n in nums2)
            hs2.Add(n);

        return hs1.Where(p=>hs2.Contains(p)).ToArray();
    }
}
// @lc code=end

