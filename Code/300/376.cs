using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int WiggleMaxLength(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        else if (nums.Length <= 1)
            return nums.Length;
        var previousStatus = 0;
        var maxLength = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            var currentStatus = (nums[i] - nums[i - 1]) > 0 ? 1 : (nums[i] - nums[i - 1]) < 0 ? -1 : 0;
            if (currentStatus != 0 && previousStatus != currentStatus)
            {
                maxLength++;
                previousStatus = currentStatus;
            }
        }
        return maxLength + 1;
    }
}