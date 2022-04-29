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
        var dict = new Dictionary<int, int>();
        foreach (var v in arr)
        {
            if (dict.ContainsKey(v))
                dict[v]++;
            else
                dict[v] = 1;
        }
        var hs2 = new HashSet<int>();
        foreach (var keyValue in dict)
        {
            if (hs2.Contains(keyValue.Value))
                return false;
            hs2.Add(keyValue.Value);
        }

        return true;
    }
}
// @lc code=end

