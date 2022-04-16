public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
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
                foreach (var item in CombinationSumSorted(candidates, target - candidates[i], i - 1))
                {
                    item.Add(candidates[i]);
                    results.Add(item);
                }
            }
            
            while (i > 0 && candidates[i - 1] == candidates[i])
                i--;
        }
        return results;
    }
}


