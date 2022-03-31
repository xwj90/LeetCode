public class Solution
{
    Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();
    public int LongestPalindromeSubseq(string s)
    {
        return LongestPalindromeSubseq(s, 0, s.Length - 1);
    }
    public int LongestPalindromeSubseq(string s, int l, int r)
    {
        var max = 0;
        if (l <= r)
        {
            if (cache.ContainsKey((l, r))) return cache[(l, r)];
            if (s[l] == s[r]) max = (l == r ? 1 : 2) + LongestPalindromeSubseq(s, l + 1, r - 1);
            else max = Math.Max(LongestPalindromeSubseq(s, l, r - 1), LongestPalindromeSubseq(s, l + 1, r));
            cache[(l, r)] = max;
        }
        return max;
    }
}
// @lc code=end

