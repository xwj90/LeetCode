using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public int[,] ReconstructQueue(int[,] people)
    {
        var order = new Dictionary<int, List<Tuple<int, int>>>();
        for (int i = 0; i < people.GetLength(0); i++)
        {
            if (!order.ContainsKey(people[i, 0]))
                order[people[i, 0]] = new List<Tuple<int, int>>();
            order[people[i, 0]].Add(new Tuple<int, int>(people[i, 0], people[i, 1]));
        }
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();
        foreach (var g in order.OrderByDescending(p => p.Key))
        {
            foreach (var item in g.Value.OrderBy(p => p.Item2))
            {
                result.Insert(item.Item2, item);
            }

        }
        int[,] r = new int[people.GetLength(0), people.GetLength(1)];
        for (int i = 0; i < result.Count; i++)
        {
            r[i, 0] = result[i].Item1;
            r[i, 1] = result[i].Item2;
        }
        return r;
    }
}