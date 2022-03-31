
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public int Rob(int[] nums)
    {
        int a = 0;
        int b = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
                a = Math.Max(a + nums[i], b);
            else
                b = Math.Max(a, +b + nums[i]);
        }
        return Math.Max(a, b);
    }


        //public int Rob(int[] nums)
        //{
        //    int[] sum = new int[nums.Length];
        // return    Rob(sum, nums, nums.Length - 1);
        //}

        //private int Rob(int[] sum, int[] nums, int v)
        //{
        //    if (v <= 1)
        //        return Math.Max(sum[0], sum[1]);
        //    if (sum[v] != 0)
        //        return sum[v];
        //    var temp = Math.Max(Rob(sum, nums, v - 1), Rob(sum, nums, v - 2) + nums[v]);
        //    sum[v] = temp;
        //    return temp;
        //}
    }