/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 1)
            return nums.Length;

        var start = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[start])
            {
                nums[++start] = nums[i];
            }
        }
        return start + 1;
    }
}
// @lc code=end

