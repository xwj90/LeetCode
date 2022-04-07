public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var res = new List<int>();
        var q = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (q.Any() && q.First() == i - k)
                q.RemoveAt(0);

            while (q.Any() && nums[i] >= nums[q.Last()])
                q.RemoveAt(q.Count - 1);

            q.Add(i);

            if (i >= k - 1)
                res.Add(nums[q.First()]);
        }

        return res.ToArray();
    }
}
// @lc code=end

