/*
 * @lc app=leetcode id=922 lang=csharp
 *
 * [922] Sort Array By Parity II
 */

// @lc code=start
public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        var odd = 1;
        var even = 0;
        while (odd < nums.Length && even < nums.Length)
        {
            if (nums[even] % 2 == 0)
            {
                even += 2;
            }
            else if (nums[odd] % 2 == 1)
            {
                odd += 2;
            }
            else
            {
                var temp = nums[even];
                nums[even] = nums[odd];
                nums[odd] = temp;
            }
        }
        return nums;
    }
}
// @lc code=end

