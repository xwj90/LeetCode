/*
 * @lc app=leetcode id=678 lang=csharp
 *
 * [678] Valid Parenthesis String
 */

// @lc code=start
public class Solution
{
    public bool CheckValidString(string s)
    {
        var lo = 0;
        var hi = 0;
        foreach (var c in s)
        {
            lo += c == '(' ? 1 : -1;
            hi += c != ')' ? 1 : -1;
            if (hi < 0) break;
            lo = Math.Max(lo, 0);
        }
        return lo == 0;
    }
}
// @lc code=end

