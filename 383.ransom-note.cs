public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var arr = new int[26];

        foreach (var c in magazine)
            arr[c - 'a']++;

        foreach (var c in ransomNote)
            arr[c - 'a']--;

        return arr.All(p => p >= 0);
    }
}
// @lc code=end

