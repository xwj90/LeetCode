public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var results = new List<IList<int>>();
        if (k == 1)
            for (var i = 1; i <= n; i++)
                results.Add(new List<int>() { i });
        else
        {
            for (var n1 = n; n1 >= k; n1--) //first element is n, n-1, n-2
            {
                var result = Combine(n1 - 1, k - 1);
                foreach (var list in result)
                {
                    list.Add(n1);
                    results.Add(list);
                }
            }
        }
        return results;
    }
}
// @lc code=end

