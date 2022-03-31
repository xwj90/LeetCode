/*
 * @lc app=leetcode id=467 lang=csharp
 *
 * [467] Unique Substrings in Wraparound String
 */

// @lc code=start
public class Solution
{
    public int FindSubstringInWraproundString(string p)
    {
        var count = new int[26];
        var maxLength = 0;
        for (var i = 0; i < p.Length; i++)
        {
            if (i > 0 && (p[i] - p[i - 1] == 1 || p[i] - p[i - 1] == -25))
                maxLength++;
            else
                maxLength = 1;
            var idx = p[i] - 'a';
            count[idx] = Math.Max(count[idx], maxLength);
        }

        return count.Sum();
    }
}
// @lc code=end

