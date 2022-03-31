
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;
        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
                return new int[] { left + 1, right + 1 };
            else if (sum > target)
                right--;
            else
                left++;
        }
        return null;
    }
}