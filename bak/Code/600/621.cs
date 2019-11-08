using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        int[] count = new int[26];
        foreach (var c in tasks)
            count[c - 'A']++;
        int max = 0;
        int num = 0;
        foreach (var c in count)
            max = Math.Max(max, c);
        foreach (var c in count)
            num += c == max ? 1 : 0;

        return Math.Max(tasks.Length, (max - 1) * (1 + n) + num);
    }


}