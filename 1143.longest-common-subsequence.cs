public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        if (text2.Length > text1.Length) return LongestCommonSubsequence(text2, text1);

        var m = new int[text1.Length + 1, text2.Length + 1];
        for (var i = 1; i <= text1.Length; i++)
            for (var j = 1; j <= text2.Length; j++)
                if (text1[i - 1] == text2[j - 1]) m[i, j] = m[i - 1, j - 1] + 1;
                else m[i, j] = Math.Max(m[i - 1, j], m[i, j - 1]);

        return m[text1.Length, text2.Length];
    }
}
// @lc code=end

