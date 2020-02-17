/*
 * @lc app=leetcode id=345 lang=csharp
 *
 * [345] Reverse Vowels of a String
 */

// @lc code=start
public class Solution
{
    public string ReverseVowels(string s)
    {
        var vowels = "aeiouAEIOU";
        var left = 0;
        var right = s.Length - 1;
        var chars =s.ToCharArray();
        while (left < right)
        {
            while (left < right && !vowels.Contains(s[left])) left++;
            while (left < right && !vowels.Contains(s[right])) right--;
            chars[left] = s[right];
            chars[right] =s[left];
            right--;
            left++;
        }
        return new string(chars);
    }
}
// @lc code=end

