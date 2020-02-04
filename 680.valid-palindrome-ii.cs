public class Solution
{
    public bool ValidPalindrome(string s)
    {
        var l = 0;
        var r = s.Length - 1;
        while (l <= r)
        {
            if (s[l] != s[r])
                return TrueValidPalindrome(s, l + 1, r) || TrueValidPalindrome(s, l, r - 1);
            l++;
            r--;
        }

        return true;
    }

    public bool TrueValidPalindrome(string s, int l, int r)
    {
        while (l <= r)
            if (s[l++] != s[r--]) return false;
        return true;
    }
}
// @lc code=end

