public class Solution
{
    public IList<IList<int>> CombinationSum3(int k, int n, int? val = null)
    {
        var results = new List<IList<int>>();
        var target = val ?? n;

        if (val < k)
            return results;

        if (k == 1)
        {
            if (target <= n && target <= 9)
                results.Add(new List<int>() { target });
            return results;
        }

        for (var i = Math.Min(9, n); i >= k; i--)
        {
            foreach (var item in CombinationSum3(k - 1, i - 1, target - i))
            {
                item.Add(i);
                results.Add(item);
            }
        }

        return results;
    }
}
// @lc code=end

