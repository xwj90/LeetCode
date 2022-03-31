using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (var w in words)
        {
            if (dict.ContainsKey(w))
                dict[w]++;
            else
                dict[w] = 1;
        }
        //c# does not have Max Heap
        return dict.OrderByDescending(p => p.Value).ThenBy(p => p.Key).Take(k).Select(p => p.Key).ToList();
    }
}