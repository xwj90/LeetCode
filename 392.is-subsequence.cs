public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;
        var dict = new Dictionary<(int i, int j), bool>();
        return IsSubsequence(s, 0, t, 0, dict);
    }

    public bool IsSubsequence(string s, int i, string t, int j, Dictionary<(int i, int j), bool> dict)
    {
        if (dict.ContainsKey((i, j))) return dict[(i, j)];
        var status = false;
        for (var k = j; k < t.Length; k++)
        {
            if (t[k] == s[i])
            {
                if (i == s.Length - 1) status = true;
                else status = IsSubsequence(s, i + 1, t, k + 1, dict);
                break;
            }
        }
        dict[(i, j)] = status;
        return status;
    }
}
// @lc code=end

