using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 78. Subsets
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Subsets(int[] nums)
    {
        List<IList<int>> results = new List<IList<int>>() { new List<int>() };
        Array.Sort(nums);
        Subsets(nums, 0, results, new List<int>());
        return results;
    }

    private void Subsets(int []nums, int v, List<IList<int>> results,List<int> ls)
    {
        for (int i = v; i < nums.Length; i++)
        {
            ls.Add(nums[i]);
            results.Add(new List<int>(ls));
            Subsets(nums, i + 1, results, ls);
            ls.RemoveAt(ls.Count - 1);
        }
    }
}
