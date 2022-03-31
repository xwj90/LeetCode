/*
 * @lc app=leetcode id=647 lang=csharp
 *
 * [647] Palindromic Substrings
 */

// @lc code=start
public class Solution
{
    public int CountSubstrings(string s)
    {

        var res = 0;
        for (var i = 0; i < s.Length; i++)
        {
            res += PalindromicFromCenter(i, s, 1);
            res += PalindromicFromCenter(i, s, 0);
        }
        return res;
    }
    public int PalindromicFromCenter(int i, string s, int odd = 1)
    {
        var left = i;
        var right = odd == 1 ? i : i + 1;
        var res = 0;
        while (left >= 0 && right < s.Length)
        {
            if (s[left--] == s[right++])
                res++;
            else
                return res;
        }
        return res;
    }
}
// @lc code=end

