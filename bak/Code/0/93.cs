using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public IList<string> RestoreIpAddresses(string s)
    {
        var result = new List<string>();
        for (int i = 1; i < 4 && i < s.Length - 2; i++)
            for (int j = i + 1; j < i + 4 && j < s.Length - 1; j++)
                for (int k = j + 1; k < j + 4 && k < s.Length; k++)
                    if (RestoreIpAddresses_IsValid(s.Substring(0, i)) && RestoreIpAddresses_IsValid(s.Substring(i, j - i))
   && RestoreIpAddresses_IsValid(s.Substring(j, k - j)) && RestoreIpAddresses_IsValid(s.Substring(k))
                           )
                    {
                        result.Add($"{s.Substring(0, i)}.{s.Substring(i, j - i)}.{s.Substring(j, k - j)}.{s.Substring(k)}");
                    }
        return result;

    }

    private bool RestoreIpAddresses_IsValid(string v)
    {
        if (v.Length > 3 || v.Length == 0 || (v[0] == '0' && v.Length > 1) || Convert.ToInt32(v) > 255)
            return false;
        return true;
    }
}