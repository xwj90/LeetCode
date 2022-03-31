/*
 * @lc app=leetcode id=239 lang=csharp
 *
 * [239] Sliding Window Maximum
 */

// @lc code=start
public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0) return new int[0];
        var res = new List<int>();
        var q = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            while (q.Any() && q[0] < i + 1 - k) q.RemoveAt(0);

            while (q.Any() && nums[q.Last()] < nums[i]) q.RemoveAt(q.Count - 1);

            q.Add(i);

            if (i >= k - 1) res.Add(nums[q.First()]);
        }
        return res.ToArray();

    }
}
// @lc code=end

