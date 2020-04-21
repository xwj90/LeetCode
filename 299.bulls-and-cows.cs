/*
 * @lc app=leetcode id=299 lang=csharp
 *
 * [299] Bulls and Cows
 */

// @lc code=start
public class Solution
{
    public string GetHint(string secret, string guess)
    {
        var bulls = 0;
        var cows = 0;
        var nums = new int[10];

        for (var i = 0; i < secret.Length; i++)
        {
            if (guess[i] == secret[i])
            {
                bulls++;
            }
            else
            {
                if (nums[secret[i] - '0']++ < 0) cows++;
                if (nums[guess[i] - '0']-- > 0) cows++;
            }
        }

        return $"{bulls}A{cows}B";
    }
}
// @lc code=end

