using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 58. Length of Last Word
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        var length = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
                return length;
            else
                length++;
        }

        return length == s.Length ? length : 0;
    }
}
