/*
 * @lc app=leetcode id=854 lang=csharp
 *
 * [854] K-Similar Strings
 */

// @lc code=start
public class Solution
{
    public int KSimilarity(string A, string B)
    {
        if (A.Length != B.Length)
            return -1;

        var count1 = new int[26];
        var count2 = new int[26];
        var diff = 0;
        for (var i = 0; i < A.Length; i++)
        {
            if (A[i] != B[i]) diff++;
            count1[A[i] - 'a']++;
            count2[B[i] - 'a']++;
        }

        for (var i = 0; i < count1.Length; i++)
        {
            if (count1[i] != count2[i])
                return -1;
        }

        return diff / 2 + (diff % 2);
    }
}
// @lc code=end

