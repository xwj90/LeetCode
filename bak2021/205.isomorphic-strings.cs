public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var m = new int[512];
        for (var i = 0; i < s.Length; i++)
        {
            if (m[s[i]] != m[t[i] + 256]) return false;
            m[s[i]] = i + 1;
            m[t[i] + 256] = i + 1;
        }
        return true;
    }
}
// @lc code=end

