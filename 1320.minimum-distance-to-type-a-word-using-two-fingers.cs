/*
 * @lc app=leetcode id=1320 lang=csharp
 *
 * [1320] Minimum Distance to Type a Word Using Two Fingers
 */

// @lc code=start
public class Solution //i don't know how to do it
{
    public int MinimumDistance(string word)
    {
        var dp = new int[26];
        var res = 0;
        var save = 0;
        for (int i = 0; i < word.Length - 1; i++)
        {
            int b = word[i] - 'A';
            var c = word[i + 1] - 'A';
            for (int a = 0; a < 26; ++a)
                dp[b] = Math.Max(dp[b], dp[a] + d(b, c) - d(a, c));
            save = Math.Max(save, dp[b]);
            res += d(b, c);
        }
        return res - save;

    }


    private int d(int a, int b)
    {
        return Math.Abs(a / 6 - b / 6) + Math.Abs(a % 6 - b % 6);
    }
}
// @lc code=end

