/*
 * @lc app=leetcode id=442 lang=csharp
 *
 * [442] Find All Duplicates in an Array
 */

// @lc code=start
public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var res = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var idx = Math.Abs(nums[i]) - 1;
            if (nums[idx] < 0) res.Add(Math.Abs(nums[i]));
            else nums[idx] = -nums[idx];
        }
        return res;
    }
}
// @lc code=end

