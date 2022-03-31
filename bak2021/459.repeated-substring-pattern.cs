/*
 * @lc app=leetcode id=459 lang=csharp
 *
 * [459] Repeated Substring Pattern
 */

// @lc code=start
public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        return (s + s).Substring(1, s.Length * 2 - 2).Contains(s);
    }
}
// @lc code=end

