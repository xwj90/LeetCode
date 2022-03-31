using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 55. Jump Game 
    /// need attention
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool CanJump(int[] nums)
    {
        var last = nums.Length - 1;
        for(var i=nums.Length-2;i>=0;i--)
            if (i + nums[i] >= last) last = i;
        return last <= 0;
    }
    
}
