/*
 * @lc app=leetcode id=824 lang=csharp
 *
 * [824] Goat Latin
 */

// @lc code=start
public class Solution
{
    public string ToGoatLatin(string S)
    {
        var vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
        var g = S.Split(' ')
        .Select(p => vowel.Contains(p.ToLower()[0]) ? p + "ma" : p.Substring(1) + p[0] + "ma")
        .ToArray();
        var a = "a";
        for (var i = 0; i < g.Length; i++)
        {
            g[i] = g[i] + a;
            a += "a";
        }

        return string.Join(" ", g);
    }
}
// @lc code=end

