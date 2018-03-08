using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 14. Longest Common Prefix
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";
        else if (strs.Length == 1)
            return strs[0];

        var minLength = int.MaxValue;
        for (int i = 0; i < strs.Length; i++)
            minLength = Math.Min(strs[i].Length, minLength);

        for (int i = 0; i < minLength; i++)
        {
            var a = strs[0][i];
            for (int j = 0; j < strs.Length; j++)
                if (strs[j][i] != strs[0][i])
                    return strs[0].Substring(0, i);
        }
        return strs[0].Substring(0, minLength);
    }
}





