public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var res = new List<int>();
        var target = new int[26];
        var current = new int[26];
        foreach (var c in p)
            target[c - 'a']++;

        for (int i = 0; i < s.Length; i++)
        {
            current[s[i] - 'a']++;

            if (i >= p.Length)
                current[s[i - p.Length] - 'a']--;

            if (Enumerable.SequenceEqual(current, target))
                res.Add(i - p.Length + 1);
        }
        return res;
    }
}
// @lc code=end

