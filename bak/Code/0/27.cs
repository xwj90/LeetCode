using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var id = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
                nums[id++] = nums[i];
        }
        return id;
    }

}





