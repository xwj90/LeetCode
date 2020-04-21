/*
 * @lc app=leetcode id=485 lang=csharp
 *
 * [485] Max Consecutive Ones
 */

// @lc code=start
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var slow = 0;
        var res = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                if (i > 0 && nums[i - 1] != 1)
                {
                    slow = i;
                }
                res = Math.Max(res, i - slow + 1);
            }
        }
        return res;

    }
}
// @lc code=end

