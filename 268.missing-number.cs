/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */

// @lc code=start
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var sum = nums.Length * (nums.Length + 1) / 2;
        for (var i = 0; i < nums.Length; i++)
        {
            sum -= nums[i];
        }
        return sum;
    }
}
// @lc code=end

