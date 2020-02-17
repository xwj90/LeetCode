/*
 * @lc app=leetcode id=532 lang=csharp
 *
 * [532] K-diff Pairs in an Array
 */

// @lc code=start
public class Solution
{
    public int FindPairs(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k < 0) return 0;
        var d = new Dictionary<int, int>();
        var res = 0;
        foreach (var n in nums)
        {
            if (!d.ContainsKey(n)) d[n] = 0;
            d[n]++;
        }

        foreach (var pair in d)
        {
            if (k == 0 && pair.Value >= 2) res++;
            else if (k != 0 && d.ContainsKey(pair.Key + k)) res++;
        }
        return res;
    }
}
// @lc code=end

