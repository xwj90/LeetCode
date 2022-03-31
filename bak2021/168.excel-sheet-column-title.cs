/*
 * @lc app=leetcode id=168 lang=csharp
 *
 * [168] Excel Sheet Column Title
 */

// @lc code=start
public class Solution
{
    public string ConvertToTitle(int n)
    {
        var ans = "";
        while (n-- > 0)
        {
            ans = (char)(n % 26 + 'A') + ans;
            n /= 26;
        }
        return ans;
    }
}
// @lc code=end

