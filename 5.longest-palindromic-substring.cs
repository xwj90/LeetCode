/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return string.Empty;

        int start = 0;
        var len = 0;
        for (var i = 0; i < s.Length; i++)
        {
            int len1 = ExpandeAroundCenter(s, i, i);
            int len2 = ExpandeAroundCenter(s, i, i + 1);
            var maxLen = Math.Max(len1, len2);
            if (maxLen > len)
            {
                len = Math.Max(len, maxLen);
                start = i - (len - 1) / 2;
            }
        }
        return s.Substring(start, len);
    }
    private int ExpandeAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }
}
// @lc code=end

