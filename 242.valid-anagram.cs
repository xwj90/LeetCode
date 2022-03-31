/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution
{
    public bool IsAnagram(string s, string t)
    {

        var val = new int[26];
        foreach (var a in s)
            val[a - 'a']++;
        foreach (var a in t)
            val[a - 'a']--;

        return val.All(p => p == 0);
    }
}
// @lc code=end

