/*
 * @lc app=leetcode id=844 lang=csharp
 *
 * [844] Backspace String Compare
 */

// @lc code=start
public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        return GetString(s) == GetString(t);
    }
    private string GetString(string s)
    {
        var chars = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '#')
            {
                if (chars.Any())
                    _ = chars.Pop();
            }
            else
            {
                chars.Push(c);
            }
        }
        return new string(chars.ToArray());
    }
}
// @lc code=end

