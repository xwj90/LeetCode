using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public IList<int> FindDuplicates(int[] nums)
    {
        List<int> r = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var id = Math.Abs(nums[i] + 1);
            if (nums[id] < 0)
                r.Add(nums[Math.Abs(id + 1)]);
            else
                nums[id] = -nums[id];
        }
        return r;
    }
}