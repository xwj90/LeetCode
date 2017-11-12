using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var a = candidates;
        Array.Sort(a);
        return CombinationSum2(a, target, new HashSet<int>(), 0);
    }
    public IList<IList<int>> CombinationSum2(int[] a, int target, HashSet<int> used, int id)
    {
        int? last = null;
        var list = new List<IList<int>>();
        for (int i = id; i < a.Length; i++)
        {
            if (last == a[i])
                continue;
            else if (last == null || last!=a[i])
                last = a[i];
            if (a[i] == target)
            {
                list.Add(new List<int>() { a[i] });
                return list;
            }
            else if (a[i] < target)
            {
                var subList = CombinationSum2(a, target - a[i], used, i + 1);
                if (subList.Count > 0)
                {
                    foreach (var item in subList)
                        item.Add(a[i]);
                    list.AddRange(subList);
                }
            }
        }
        return list;
    }

}





