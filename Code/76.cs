using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    Dictionary<char, int> MinWindow_dict = new Dictionary<char, int>();
    public string MinWindow(string s, string t)
    {

        for (int j = 0; j < t.Length; j++)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (t[j] == s[i])
                {
                    MinWindow_dict[s[i]] = i;
                    break;
                }
            }
        }
        if (MinWindow_dict.Count < t.Length)
            return "";
        var start = MinWindow_dict.Min(p => p.Value);
        var end = MinWindow_dict.Max(p => p.Value);
        for (int i = 0; i < s.Length; i++)
        {


        }
    }
}
