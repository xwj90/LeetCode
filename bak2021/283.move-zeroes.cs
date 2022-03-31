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
        var count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                count++;
            }
        }
        var ind = 0;
        var nonZeroInd = 0;
        for (int i = 0; i < count; i++)
        {
            while (nums[nonZeroInd] == 0)
            {
                nonZeroInd++;
            }
            nums[i] = nums[nonZeroInd];
            nonZeroInd++;
        }

        for (int i = count; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
// @lc code=end

