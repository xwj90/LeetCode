using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public int SubarraySum(int[] nums, int k)
    {
        if (nums.Length == 0)
            return 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int sum = 0;
        int r = 0;
        dict[0] = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (dict.ContainsKey(sum - k))
                r += dict[sum - k];
            dict[sum]= (dict.ContainsKey(sum) ? dict[sum] : 0) + 1;
        }
        return r;
    }
}