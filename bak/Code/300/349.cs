using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> hs1 = new HashSet<int>();
        HashSet<int> hs2 = new HashSet<int>();
        foreach (var n in nums1)
        {
            hs1.Add(n);
        }
        foreach (var n in nums2)
        {
            if (hs1.Contains(n))
                hs2.Add(n);
        }
        return hs2.ToArray();
    }
}