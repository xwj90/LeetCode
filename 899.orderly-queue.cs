/*
 * @lc app=leetcode id=899 lang=csharp
 *
 * [899] Orderly Queue
 */

// @lc code=start
public class Solution
{
    public string OrderlyQueue(string S, int K)
    {
        if (K == 1)
        {
            var ans = S;
            for (int i = 0; i < S.Length; i++)
            {
                var s = S.Substring(i) + S.Substring(0, i);
                if (string.Compare(s, ans) == -1) ans = s;
            }
            return ans;
        }

        return new string(S.ToCharArray().OrderBy(p => p).ToArray());

    }
}
// @lc code=end

