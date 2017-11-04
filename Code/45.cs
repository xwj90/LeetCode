using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
 
    public int Jump(int[] nums)
    {
        if (nums.Length < 2)
            return 0;
        int level = 0;
        int currentMax = 0;
        int i = 0;
        int nextMax = 0;
        while (currentMax - i + 1 > 0)
        {
            level++;
            for ( ; i <= currentMax; i++)
            {
                nextMax = Math.Max(nextMax, nums[i] + i);
                if (nextMax >= nums.Length - 1) return level;
            }
            currentMax = nextMax;
        }
        return 0;
    }

}
