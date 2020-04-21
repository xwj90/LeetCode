/*
 * @lc app=leetcode id=1207 lang=csharp
 *
 * [1207] Unique Number of Occurrences
 */

// @lc code=start
public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {

        var e = arr.GroupBy(p => p).Select(p => p.Count());
        return e.Distinct().Count() == e.Count();
    }
}
// @lc code=end

