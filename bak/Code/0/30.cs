using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> r = new List<int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        int total = 0;
        foreach (var item in words)
        {
            if (dict2.ContainsKey(item))
                dict2[item]++;
            else
                dict2[item] = 1;
            total++;
        }
        var l = words[0].Length;
        for (int j = 0; j < l; j++) //start point
        {
            var dict = dict2.ToDictionary(p => p.Key, p => p.Value);
            var i = j;
            var start = i;
            var count = 0;
            while (i + l <= s.Length)
            {
                var w = s.Substring(i, l);
                if (dict.ContainsKey(w))
                {
                    var v = dict[w];
                    if (v == 1)
                        dict.Remove(w);
                    else
                        dict[w]--;
                    count++;
                    i += l;
                    if (dict.Count == 0)
                    {
                        r.Add(start);

                    }
                }
                else
                {
                    //dict = dict2.ToDictionary(p => p.Key, p => p.Value);
                    if (count == 0)
                    {
                        i += l;
                        start = i;
                    }
                    else
                    {

                        var pword = s.Substring(start, l);
                        while (start < i)
                        {
                            if (!dict.ContainsKey(pword))
                                dict[pword] = 0;
                            dict[pword]++;
                            count--;
                            start += l;
                            if (pword == w)
                            {
                                pword = s.Substring(start, l);
                                break;
                            }
                            else
                                pword = s.Substring(start, l);
                        }
                    }


                }

            }
        }
        return r;
    }
}





