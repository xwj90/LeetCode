/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var count = new int[26];
        foreach (var n in magazine)
            count[n - 'a']++;
        foreach (var n in ransomNote)
            count[n - 'a']--;
        return count.All(p => p >= 0);
    }
}
// @lc code=end

