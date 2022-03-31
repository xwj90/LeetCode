/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        long product = 1;
        var numOfZero = 0;
        foreach (var n in nums)
        {
            if (n == 0) numOfZero++;
            else product *= n;
        }

        var results = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0 && numOfZero == 1) results[i] = Convert.ToInt32(product);
            if (nums[i] != 0 && numOfZero == 0) results[i] = Convert.ToInt32(product / nums[i]);
        }
        return results;
    }
}
// @lc code=end

