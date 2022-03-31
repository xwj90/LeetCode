/*
 * @lc app=leetcode id=290 lang=csharp
 *
 * [290] Word Pattern
 */

// @lc code=start
public class Solution
{
    public bool WordPattern(string pattern, string str)
    {
        var patterns = pattern.ToCharArray();
        var strs = str.Split(' ');

        if (patterns.Length != strs.Length)
            return false;

        var dict = new Dictionary<char, string>();
        var dict2 = new Dictionary<string, char>();
        for (var i = 0; i < patterns.Length; i++)
        {
            if (dict.ContainsKey(patterns[i]) && dict[patterns[i]] != strs[i])
            {
                return false;
            }            
            dict[patterns[i]] = strs[i];

            if (dict2.ContainsKey(strs[i]) && dict2[strs[i]] != patterns[i])
            {
                return false;
            }
            dict2[strs[i]] = patterns[i];
        }

        return true;

    }
}
// @lc code=end

