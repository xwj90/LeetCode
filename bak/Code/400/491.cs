using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        List<IList<int>> res = new List<IList<int>>();
        FindSubsequences_Helper(new List<int>(), 0, nums, res);
        return res;
    }

    private void FindSubsequences_Helper(List<int> list, int v, int[] nums, List<IList<int>> res)
    {
        if (list.Count > 1) res.Add(new List<int>(list));
        HashSet<int> used = new HashSet<int>();
        for (int i = v; i < nums.Length; i++)
        {
            if (used.Contains(nums[i])) continue;
            if(list.Count==0 || nums[i]>=list.Last())
            {
                used.Add(nums[i]);
                list.Add(nums[i]);
                FindSubsequences_Helper(list, i + 1, nums, res);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}