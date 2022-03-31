using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public string AddBinary(string a, string b)
    {
        int i = 0;
        int j = 0;
        int m = 0;
        StringBuilder sb = new StringBuilder();
        while (i < a.Length || j < b.Length || m == 1)
        {
            var va = i < a.Length ? (a[a.Length - 1 - i] == '1' ? 1 : 0) : 0;
            var vb = j < b.Length ? (b[b.Length - 1 - j] == '1' ? 1 : 0) : 0;
            var sum = va + vb + m;
            m = sum / 2;
            var s = (sum % 2).ToString();
            sb.Append(s);
            i++;
            j++;
        }
        return new string(sb.ToString().Reverse().ToArray());
    }


}
