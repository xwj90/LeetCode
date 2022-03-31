using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length == 0 && needle.Length == 0)
            return 0;
        for (int i = 0; i < haystack.Length; i++)
        {
            var allmatch = true;
            for (int j = 0; j < needle.Length   ; j++)
            {
                if ((i + j) >= haystack.Length)
                    return -1;
                if (haystack[i + j] != needle[j])
                {
                    allmatch = false;
                    break;
                }
            }
            if (allmatch)
            {
                return i;
            }
        }
        return -1;
    }
}





