/*
 * @lc app=leetcode id=565 lang=csharp
 *
 * [565] Array Nesting
 */

// @lc code=start
public class Solution
{
    public int ArrayNesting(int[] nums)
    {
        var visited = new bool[nums.Length];
        var res = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (!visited[i])
            {
                var start = nums[i];
                var count = 0;
                do
                {
                    start = nums[start];
                    count++;
                    visited[start] = true;
                } while (start != nums[i]);
                res = Math.Max(res, count);
            }
        }
        return res;
    }
}
// @lc code=end

