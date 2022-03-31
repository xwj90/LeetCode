/*
 * @lc app=leetcode id=525 lang=csharp
 *
 * [525] Contiguous Array
 */

// @lc code=start
public class Solution
{
    public int FindMaxLength(int[] nums)
    {

        var dict = new Dictionary<int, int>();
        dict[0] = -1;
        var current = 0;
        var longest = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            current += (nums[i] == 1 ? 1 : -1);
            if (dict.ContainsKey(current))
                longest = Math.Max(longest, i - dict[current]);
            else
                dict[current] = i;
        }
        return longest;

    }
}
// @lc code=end

