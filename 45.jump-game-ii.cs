/*
 * @lc app=leetcode id=45 lang=csharp
 *
 * [45] Jump Game II
 */

// @lc code=start
public class Solution
{
    public int Jump(int[] nums)
    {
        if (nums.Length < 2)
            return 0;
        int level = 0;
        int right = 0;
        int left = 0;
        int nextRight = 0;
        while (right - left + 1 > 0)
        {
            level++;
            for (; left <= right; left++)
            {
                nextRight = Math.Max(nextRight, nums[left] + left);
                if (nextRight >= nums.Length - 1) return level;
            }
            right = nextRight;
        }
        return 0;
    }
}
// @lc code=end

