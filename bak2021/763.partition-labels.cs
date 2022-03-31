/*
 * @lc app=leetcode id=763 lang=csharp
 *
 * [763] Partition Labels
 */

// @lc code=start
public class Solution
{
    public IList<int> PartitionLabels(string S)
    {
        var last = new int[26];
        for (var i = 0; i < S.Length; i++)
            last[S[i] - 'a'] = i;

        var j = 0;
        var anchor = 0;
        var res = new List<int>();
        for (var i = 0; i < S.Length; i++)
        {
            j = Math.Max(j, last[S[i] - 'a']);
            if (i == j)
            {
                res.Add(i - anchor + 1);
                anchor = i + 1;
            }
        }
        return res;
    }
}
// @lc code=end

