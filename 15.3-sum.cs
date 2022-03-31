public class Solution
{
    public (int x, int y, int z) Order(int a, int b, int c)
    {
        var max = Math.Max(a, Math.Max(b, c));
        var min = Math.Min(a, Math.Min(b, c));
        var mid = a + b + c - max - min;
        return (min, mid, max);
    }
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
            dict[nums[i]] = i;

        var result = new HashSet<(int x, int y, int z)>();

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                var target = 0 - nums[i] - nums[j];
                if (dict.ContainsKey(target))
                {
                    var k = dict[target];
                    if (i != k && j != k)
                    {
                        result.Add(Order(nums[i], nums[j], nums[k]));
                    }
                }
            }
        }
        return result.Select(p => (IList<int>)new List<int>() { p.x, p.y, p.z }).ToList();

    }

}
// @lc code=end

