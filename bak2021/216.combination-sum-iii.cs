public class Solution
{
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        if (n / k >= 9 && k > 1) return new List<IList<int>>();
        return CombinationSum3(k, n, 1);
    }

    public IList<IList<int>> CombinationSum3(int k, int n, int start)
    {
        var res = new List<IList<int>>();
        if (k == 1)
        {
            if (start <= n && n <= 9)
            {
                res.Add(new List<int>() { n });
            }
            else
            {
                return res;
            }
        }

        for (var i = start; i < n && i < 10; i++)
        {
            var result = CombinationSum3(k - 1, n - i, i + 1);
            foreach (var r in result)
            {
                var item = new List<int>() { i };
                item.AddRange(r);
                res.Add(item);
            }
        }
        return res;
    }
}
// @lc code=end

