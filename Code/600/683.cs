using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    /// <summary>
    /// 683. K Empty Slots
    /// </summary>
    /// <param name="flowers"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int KEmptySlots(int[] flowers, int k)
    {
        throw new NotImplementedException();
        //var days = new int[flowers.Length];
        //for (int i = 0; i < flowers.Length; i++)
        //    days[flowers[i] - 1] = i + 1;
        //var next = new int[flowers.Length];
        //var before = new int[flowers.Length];
        //for (int i = 0; i < flowers.Length; i++)
        //{
        //    next[i] = i + 2;
        //    before[i] = i;
        //}
        //for (int i = days.Length - 1; i >= 0; i--)//0...length
        //{
        //    before[i + 2] = next[i + 1];
        //    next[i] = before[i + 1];
        //}


        //return res == int.MaxValue ? -1 : res;
    }

    //public int KEmptySlots(int[] flowers, int k)
    //{
    //    var days = new int[flowers.Length];
    //    for (int i = 0; i < flowers.Length; i++)
    //        days[flowers[i] - 1] = i + 1;
    //    var left = 0;
    //    var right = k + 1;
    //    var res = int.MaxValue;
    //    for (int i = 0; right < days.Length; i++)
    //    {
    //        if (days[i] < days[left] || days[i] <= days[right])
    //        {
    //            if (i == right) res = Math.Min(res, Math.Max(days[left], days[right]));
    //            left = i;
    //            right = k + 1 + i;
    //        }
    //    }
    //    return res == int.MaxValue ? -1 : res;
    //}
}