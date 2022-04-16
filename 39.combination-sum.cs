public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        return CombinationSumSorted(candidates, target, candidates.Length - 1);
    }
    public IList<IList<int>> CombinationSumSorted(int[] candidates, int target, int last)
    {
        var results = new List<IList<int>>();
        for (var i = last; i >= 0; i--)
        {
            if (candidates[i] == target)
            {
                results.Add(new List<int>() { target });
            }
            else if (candidates[i] < target)
            {
                foreach (var item in CombinationSumSorted(candidates, target - candidates[i], i))
                {
                    item.Add(candidates[i]);
                    results.Add(item);
                }
            }
        }
        return results;
    }

}
// @lc code=end

