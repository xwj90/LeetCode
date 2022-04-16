public class Solution
{
    public IList<IList<int>> Subsets(int[] nums, int start = 0)
    {
        if (start == nums.Length - 1)
            return new List<IList<int>> { new List<int>(), new List<int>() { nums[start] } };

        var results = new List<IList<int>>();
        foreach (var item in Subsets(nums, start + 1))
        {
            results.Add(item);
            results.Add(item.Union(new List<int>() { nums[start] }).ToList());
        }
        return results;
    }
}
// @lc code=end

