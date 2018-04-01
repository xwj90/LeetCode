using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool CanPermutePalindrome(string s)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i] - 'a'))
                dict[s[i] - 'a'] = 0;
            dict[s[i] - 'a']++;
        }
        int odd = 0;
        foreach (var item in dict.Values)        
            if (item % 2 == 1) odd++;
        return odd <= 1;
    }
}