
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MaximumGap(int[] nums)
    {
        if (nums.Length < 2)
            return 0;
        var min = int.MaxValue;
        var max = int.MinValue;
        foreach (var n in nums)
        {
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }
        if (max == min)
            return 0;
        int[,] slot = new int[nums.Length, 2];
        for (int i = 0; i < slot.GetLength(0); i++)
        {
            slot[i, 0] = int.MaxValue;
            slot[i, 1] = int.MinValue;
        }
        var diff = (int)Math.Ceiling((double)(max - min) / (nums.Length - 1));
        foreach (var n in nums)
        {
            var id = (n - min) / diff;
            slot[id, 0] = Math.Min(n, slot[id, 0]);
            slot[id, 1] = Math.Max(n, slot[id, 1]);
        }
        var start = slot[0, 1];
        var maxGap = int.MinValue;
        for (int i = 1; i < slot.GetLength(0); i++)
        {
            if (slot[i, 0] == int.MaxValue)
                continue;
            var gap = slot[i, 0] - start;
            maxGap = Math.Max(maxGap, gap);
            start = slot[i, 1];
        }
        return maxGap;
    }
}