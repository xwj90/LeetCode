using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> d = new Dictionary<string, IList<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var a = strs[i].ToArray();
            Array.Sort(a);
            var key = new string(a);
            if (!d.ContainsKey(key))
                d[key] = new List<string>();
            d[key].Add(strs[i]);
        }
        return d.Values.ToList();
    }
}
