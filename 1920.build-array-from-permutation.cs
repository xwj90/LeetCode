/*
 * @lc app=leetcode id=1920 lang=csharp
 *
 * [1920] Build Array from Permutation
 */

// @lc code=start
public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        var n = 10000;
        for (var i = 0; i < nums.Length; i++)
        {
            var v = nums[i] % n;
            nums[i] = v + n * (nums[v] % n);
        }

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] / n;
        }
        return nums;
    }
}
// @lc code=end 