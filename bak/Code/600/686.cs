using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    /// <summary>
    /// 686. Repeated String Match
    /// </summary>
    /// <param name="A"></param>
    /// <param name="B"></param>
    /// <returns></returns>
    public int RepeatedStringMatch(string A, string B)
    {
        int count = 0;
        StringBuilder sb = new StringBuilder();
        while (sb.Length < B.Length)
        {
            sb.Append(A);
            count++;
        }
        if (sb.ToString().Contains(B)) return count;
        if (sb.Append(A).ToString().Contains(B)) return ++count;
        return -1;
    }
}