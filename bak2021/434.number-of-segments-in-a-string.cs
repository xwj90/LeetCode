/*
 * @lc app=leetcode id=434 lang=csharp
 *
 * [434] Number of Segments in a String
 */

// @lc code=start
public class Solution
{
    public int CountSegments(string s)
    {
        var count = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if ((i == 0 || s[i - 1] == ' ') && s[i] != ' ')
            {
                count++;
            }
        }
        return count;
    }
}
// @lc code=end

