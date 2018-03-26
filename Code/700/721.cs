using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        Dictionary<string, HashSet<int>> dict = new Dictionary<string, HashSet<int>>();
        for (int i = 0; i < accounts.Count; i++)
        {
            for (int j = 1; j < accounts[i].Count; j++)
            {
                if (!dict.ContainsKey(accounts[i][j]))
                    dict[accounts[i][j]] = new HashSet<int>();
                dict[accounts[i][j]].Add(i);
            }
        }

        int[] parent = new int[accounts.Count];
        for (int i = 0; i < parent.Length; i++)
            parent[i] = i;
        int[] deep = new int[accounts.Count];
        //merge
        foreach (var v in dict.Values)
        {
            if (v.Count > 1)
            {
                var a = v.ToArray();
                for (int i = 1; i < a.Length; i++)
                {
                    //connect 
                    var p1 = AccountsMerge_GetParent(a[i - 1], parent);
                    var p2 = AccountsMerge_GetParent(a[i], parent);
                    var d1 = deep[p1];
                    var d2 = deep[p2];
                    if (d1 > d2)
                        parent[p2] = p1;
                    else if (d1 < d2)
                        parent[p1] = p2;
                    else
                    {
                        parent[p1] = p2;
                        deep[p2]++;
                    }
                }
            }
        }
        HashSet<int> pid = new HashSet<int>();
        for (int i = 0; i < accounts.Count; i++)
        {
            var p = AccountsMerge_GetParent(i, parent);
            if (p != i)
                for (int j = 1; j < accounts[i].Count; j++)
                    accounts[p].Add(accounts[i][j]);
            pid.Add(p);
        }

        var result = new List<IList<string>>();
        foreach (var id in pid)
        {
            var ls = new List<string>();
            ls.Add(accounts[id][0]);
            ls.AddRange(accounts[id].Skip(1).Distinct().OrderBy(p => p, Comparer<string>.Create(string.CompareOrdinal)));
            result.Add(ls);
        }
        return result;
    }
    private int AccountsMerge_GetParent(int i, int[] parent)
    {
        if (parent[i] == i)
            return i;
        else
            return AccountsMerge_GetParent(parent[i], parent);
    }
}