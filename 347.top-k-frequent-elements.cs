/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start
public class Solution
{
    public IList<int> TopKFrequent(int[] nums, int k)
    {
        var d = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            if (!d.ContainsKey(n)) d[n] = 1;
            else d[n]++;
        }
        var s = new SortedSet<(int frequency, int value)>();
        foreach (var pair in d)
        {
            s.Add((pair.Value, pair.Key));
            if (s.Count > k)
            {
                s.Remove(s.Min);
            }
        }

        return s.Select(p => p.value).ToList();

    }
}
// @lc code=end

