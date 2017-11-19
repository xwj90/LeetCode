using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums);
        bool[] status = new bool[nums.Length];
        return PermuteUnique(nums, status, 1);
    }
    public IList<IList<int>> PermuteUnique(int[] nums, bool[] status, int level)
    {
        var r = new List<IList<int>>();
        int? last = null;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == last) continue;
            if (status[i]) continue;
            if (level == nums.Length)
            {
                r.Add(new List<int>() { nums[i] });
            }
            else
            {
                var current = nums[i];
                status[i] = true;
                var re = PermuteUnique(nums, status, level + 1);
                status[i] = false;
                foreach (var item in re)
                {
                    item.Add(nums[i]);
                    r.Add(item);
                }
            }

            if (last == null || last != nums[i])
                last = nums[i];
        }
        return r;
    }
    //public IList<IList<int>> PermuteUnique1(int[] nums)
    //{
    //    List<IList<int>> result = new List<IList<int>>();
    //    if (nums == null || nums.Length == 0) return result;
    //    var f = new List<int>();
    //    f.Add(nums[0]);
    //    result.Add(f);
    //    for (int i = 1; i < nums.Length; i++)
    //    {
    //        var newResult = new List<IList<int>>();
    //        for (int j = 0; j < result.Count; j++)
    //        {
    //            var cur = result[j];
    //            for (int k = 0; k < cur.Count + 1; k++)
    //            {
    //                var item = new List<int>(cur);
    //                item.Insert(k, nums[i]);
    //                if (newResult.Any(x => x.SequenceEqual(item)))
    //                    continue;
    //                newResult.Add(item);
    //            }
    //        }
    //        result = newResult;
    //    }
    //    return result;

    //}
}