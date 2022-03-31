/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var start = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[start++] = nums[i];
            }
        }
        return start;

    }
}
// @lc code=end

