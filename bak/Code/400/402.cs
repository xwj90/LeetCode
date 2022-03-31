using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public string RemoveKdigits(string num, int k)
    {
        var nums = num.ToCharArray().Select(p => p - '0').ToList();
        int start = 0;
        for (int j = 0; j < k; j++)
        {
            for (int i = start; i < nums.Count; i++)
                if (i == nums.Count - 1 || nums[i] > nums[i + 1])
                {
                    nums.RemoveAt(i);
                    start = Math.Max(0, i - 1);
                    break;
                }
        }
        while (nums.Count > 0 && nums[0] == 0)
            nums.RemoveAt(0);
        return nums.Count == 0 ? "0" : string.Join("", nums);
    }

}