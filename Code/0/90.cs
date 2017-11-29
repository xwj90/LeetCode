using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
     

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();
        List<int> each = new List<int>();
        SubsetsWithDup(result, each, 0, nums);
        return result;
    }

    private void SubsetsWithDup(List<IList<int>> result, List<int> each, int pos, int[] nums)
    {
        if (pos <= nums.Length)
            result.Add(new List<int>(each));
        int i = pos;
        while (i < nums.Length)
        {
            each.Add(nums[i]);
            SubsetsWithDup(result, new List<int>(each), i + 1, nums);
            each.RemoveAt(each.Count - 1);
            i++;
            while (i < nums.Length && nums[i] == nums[i - 1]) { i++; }

        }
    }
}