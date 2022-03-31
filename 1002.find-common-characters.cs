/*
 * @lc app=leetcode id=1002 lang=csharp
 *
 * [1002] Find Common Characters
 */

// @lc code=start
public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        var res = new List<string>();
        var val = new int[words.Length, 26];
        for (var i = 0; i < words.Length; i++)
        {
            foreach (var a in words[i])
                val[i, a - 'a']++;
        }

        for (var j = 0; j < 26; j++)
        {
            var min = int.MaxValue;
            for (var i = 0; i < words.Length; i++)
            {
                min = Math.Min(min, val[i, j]);
            }
            for (var i = 0; i < min; i++)
            {
                res.Add((char)('a' + j) + "");
            }
        }
        return res;

    }
}
// @lc code=end

