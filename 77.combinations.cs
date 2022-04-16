public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var results = new List<IList<int>>();
        for (var i = n; i >= k; i--)
            if (k == 1)
                results.Add(new List<int>() { i });
            else
                foreach (var item in Combine(i - 1, k - 1))
                {
                    item.Add(i);
                    results.Add(item);
                }
        return results;
    }
}
// @lc code=end

