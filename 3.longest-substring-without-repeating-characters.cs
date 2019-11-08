public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        var dict = new Dictionary<char, int>();
        var max = 0;
        for (int i = 0, j = 0; i < s.Length; ++i)
        {
            if (dict.ContainsKey(s[i]))
            {
                j = Math.Max(j, dict[s[i]] + 1);
            }
            dict[s[i]] = i;
            max = Math.Max(max, i - j + 1);
        }
        return max;
    }
}
// @lc code=end

