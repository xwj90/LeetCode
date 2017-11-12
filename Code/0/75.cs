using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public partial class Solution
{
    public void SortColors(int[] nums)
    {
        int[] id = new int[3]; 
        for (int i = 0; i < nums.Length; i++)
            id[nums[i]]++;
        int total = 0;
        for (int i = 0; i < id.Length; i++)
            for (int j = 0; j < id[i]; j++)
                nums[total++] = i;
    }
}





