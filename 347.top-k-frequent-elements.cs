public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            if (dict.ContainsKey(n))
                dict[n]++;
            else
                dict[n] = 1;
        }

        var q = new PriorityQueue<int, int>();
        foreach (var kv in dict)
        {
            q.Enqueue(kv.Key, kv.Value);
            if (q.Count == k + 1)
                q.Dequeue();
        }

        var res = new int[k];
        for (var i = 0; i < k; i++)
        {
            res[i] = q.Dequeue();
        }
        return res;
    }
}
// @lc code=end

