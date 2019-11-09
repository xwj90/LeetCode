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
        if (string.IsNullOrWhiteSpace(s)) return "";
        int start = 0;
        var len = 0;
        for (var i = 0; i < s.Length; i++)
        {
            int len1 = expandeAroundCenter(s, i, i);
            int len2 = expandeAroundCenter(s, i, i + 1);
            var len0 = Math.Max(len1, len2);
            if (len0 > len)
            {
                len = Math.Max(len, len0);
                start = i - (len - 1) / 2;
            }
        }
        return s.Substring(start, len);
    }
    private int expandeAroundCenter(string s, int left, int right)
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

