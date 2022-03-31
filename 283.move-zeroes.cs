/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public class Solution
{
    public void MoveZeroes(int[] nums)
    {

        var start = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[start++] = nums[i];
            }
        }

        for (var i = start; i < nums.Length; i++)
        {
            nums[i] = 0;
        }

    }
}
// @lc code=end

