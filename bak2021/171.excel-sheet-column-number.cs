/*
 * @lc app=leetcode id=171 lang=csharp
 *
 * [171] Excel Sheet Column Number
 */

// @lc code=start
public class Solution
{
    public int TitleToNumber(string s)
    {
        var v = 0;
        var b = 1;
        for (var i = s.Length - 1; i >= 0; i--)
        {
            v += (s[i] - 'A' + 1) * b;
            b = b * 26;
        }
        return v;
    }
}
// @lc code=end

