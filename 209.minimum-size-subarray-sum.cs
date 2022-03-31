/*
 * @lc app=leetcode id=209 lang=csharp
 *
 * [209] Minimum Size Subarray Sum
 */

// @lc code=start
public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        var minLength = int.MaxValue;
        var left = 0;
        var sum = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            
            while (sum >= target)
            {
                minLength = Math.Min(minLength, right - left + 1);
                sum -= nums[left++];
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}
// @lc code=end

