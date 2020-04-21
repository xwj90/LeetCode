/*
 * @lc app=leetcode id=1048 lang=csharp
 *
 * [1048] Longest String Chain
 */

// @lc code=start
public class Solution
{
    public int LongestStrChain(string[] words)
    {
        var dict = new Dictionary<int, List<(string, int Count)>>();
        foreach (var w in words)
        {
            if (!dict.ContainsKey(w.Length))
                dict[w] = new List<(strng, int Count)>();
            dict[w].Add((w, -1));
        }

        var min =dict.Keys.Min();
        
    }

}
// @lc code=end

