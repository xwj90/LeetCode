/*
 * @lc app=leetcode id=32 lang=csharp
 *
 * [32] Longest Valid Parentheses
 */

// @lc code=start
public class Solution
{
    public int LongestValidParentheses(string s)
    {
        int left = 0;
        int right = 0;
        int max = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                left++;
            else
                right++;

            if (right == left)
                max = Math.Max(max, 2 * right);
            else if (right > left)
                left = right = 0;
        }
        left = right = 0;
        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '(')
                left++;
            else
                right++;
            if (right == left)
                max = Math.Max(max, 2 * right);
            else if (left > right)
                left = right = 0;
        }
        return max;
    }
}
// @lc code=end

