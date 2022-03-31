/*
 * @lc app=leetcode id=151 lang=csharp
 *
 * [151] Reverse Words in a String
 */

// @lc code=start
public class Solution
{
    public string ReverseWords(string s)
    {
        var list = s.Split().Where(p => !string.IsNullOrWhiteSpace(p)).ToList();
        list.Reverse();
        return string.Join(' ', list);

    }
}
// @lc code=end

