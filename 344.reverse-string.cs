/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 */

// @lc code=start
public class Solution
{
    public void ReverseString(char[] s)
    {
        var left = 0;
        var right = s.Length - 1;
        while (right > left)
        {
            var temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            right--;
            left++;
        }
    }
}
// @lc code=end

