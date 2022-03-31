using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public IList<IList<int>> Permute(int[] nums)
    {
        return Permute(nums, 0);
    }
    public IList<IList<int>> Permute(int[] nums, int start)
    {
        List<IList<int>> ls = new List<IList<int>>();
        if (start == nums.Length - 1)
        {
            ls.Add(new List<int> { nums[nums.Length - 1] });
            return ls;
        }
        for (int i = start; i < nums.Length; i++)
        {
            var rs = Permute(nums, start + 1);
            foreach (var r in rs)
            {
                r.Insert(i - start, nums[start]);
                ls.Add(r);
            }
        }
        return ls;
    }

}
