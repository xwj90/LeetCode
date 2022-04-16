public class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        var groups = nums.GroupBy(p => p).Select(p => (p.Key, p.Count()));
        var results = new List<IList<int>>() { new List<int>() };
        foreach (var (key, count) in groups)
        {
            var current = new List<int>();
            var results2 = new List<IList<int>>();

            for (var i = 0; i <= count; i++)
            {
                foreach (var item in results)
                {
                    results2.Add(current.Concat(item).ToList());
                }
                current.Add(key);
            }
            results = results2;
        }
        return results;
    }
}
// @lc code=end

