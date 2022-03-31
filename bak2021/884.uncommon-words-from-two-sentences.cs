/*
 * @lc app=leetcode id=884 lang=csharp
 *
 * [884] Uncommon Words from Two Sentences
 */

// @lc code=start
public class Solution
{
    public string[] UncommonFromSentences(string A, string B)
    {
        var dict = new Dictionary<string, int>();
        foreach (var w in A.Split(' '))
        {
            if (!dict.ContainsKey(w)) dict[w] = 1;
            else dict[w]++;
        }
        foreach (var w in B.Split(' '))
        {
            if (!dict.ContainsKey(w)) dict[w] = 1;
            else dict[w]++;
        }

        return dict.Where(p => p.Value == 1).Select(p => p.Key).ToArray();

    }
}
// @lc code=end

