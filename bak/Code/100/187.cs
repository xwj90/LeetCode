
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        HashSet<string> keys = new HashSet<string>();
        HashSet<string> result = new HashSet<string>();
        for (int i = 0; i < s.Length - 9; i++)
        {
            var key = s.Substring(i, 10);
            if (keys.Contains(key))
                result.Add(key);
            else
                keys.Add(key);
        }
        return result.ToList();
    }
}