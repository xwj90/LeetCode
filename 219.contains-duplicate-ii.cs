/*
 * @lc app=leetcode id=219 lang=csharp
 *
 * [219] Contains Duplicate II
 */

// @lc code=start
public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                var lastI = dict[nums[i]];
                if (i - lastI <= k) return true;
            }
            dict[nums[i]] = i;
        }
        return false;
    }
}
// @lc code=end

