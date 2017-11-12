using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public int NumDecodings(string s)
    {
        if (s.Length == 0)
            return 0;
        int[] r = new int[s.Length + 1];
        r[s.Length] = 1;
        r[s.Length - 1] = s[s.Length - 1] != '0' ? 1 : 0;
        for (int i = s.Length - 2; i >= 0; i--)
        {
            if (s[i] != '0')
                r[i] = (Convert.ToInt32(s.Substring(i, 2)) <= 26) ? r[i + 1] + r[i + 2] : r[i + 1];
        }
        return r[0];
    }


}