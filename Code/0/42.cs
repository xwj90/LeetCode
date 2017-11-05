using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int Trap(int[] height)
    {
        var maxId = -1;
        var maxHeight = -1;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > maxHeight)
            {
                maxHeight = height[i];
                maxId = i;
            }
        }
        var total = 0;
        var sub = 0;
        var max = 0;
        for (int i = 0; i < maxId; i++)
        {
            if (height[i] > max)
            {
                total += (height[i] - max) * (maxId - i);
                max = height[i];
            }
            sub += height[i];
        }
        max = 0;
        for (int i = height.Length - 1; i > maxId; i--)
        {
            if (height[i] > max)
            {
                total += (height[i] - max) * (i - maxId);
                max = height[i];
            }
            sub += height[i];
        }
        return total - sub;
    }
}
