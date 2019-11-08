using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    Dictionary<char, int> MinWindow_dict = new Dictionary<char, int>();
    public string MinWindow(string s, string t)
    {
        var counter = 0;
        var d = int.MaxValue;
        var begin = 0;
        var head = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (!MinWindow_dict.ContainsKey(t[i]))
                MinWindow_dict[t[i]] = 1;
            else
                MinWindow_dict[t[i]]++;
            counter++;
        }

        for (int end = 0; end < s.Length; end++)
        {
            if (MinWindow_dict.ContainsKey(s[end]))
            {
                if (MinWindow_dict[s[end]] > 0)
                {
                    counter--;
                }
                MinWindow_dict[s[end]]--;
            }

            while (counter == 0)
            {
                if (end - begin < d)
                {
                    head = begin;
                    d = end - begin + 1;
                }
                if (MinWindow_dict.ContainsKey(s[begin]))
                {
                    if (MinWindow_dict[s[begin]] == 0)
                    {
                        counter++;
                    }
                    MinWindow_dict[s[begin]]++;
                }
                begin++;
            }
        }
        return d == int.MaxValue ? "" : s.Substring(head, d);
    }
}
