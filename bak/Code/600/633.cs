using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public bool JudgeSquareSum(int c)
    {
        if (c < 0) return false;
        int left = 0; int right = Convert.ToInt32(Math.Sqrt(c));
        while (left <= right)
        {
            var current = left * left + right * right;
            if (current < c)
                left++;
            else if (current > c)
                right--;
            else
                return true;
        }
        return false;
    }


}