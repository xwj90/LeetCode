using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var a = candidates;
        Array.Sort(a);
        return CombinationSum(a, target, new HashSet<int>(), 0);
    }
    public IList<IList<int>> CombinationSum(int[] a, int target, HashSet<int> used, int id)
    {
        var list = new List<IList<int>>();
        for (int i = id; i < a.Length; i++)
        {

            if (a[i] == target)
            {
                list.Add(new List<int>() { a[i] });
                return list;
            }
            else if (a[i] < target)
            {
                //used.Add(a[i]);
                var subList = CombinationSum(a, target - a[i], used, i);
                //used.Remove(a[i]);
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





