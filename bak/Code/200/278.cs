using System;
using System.Collections.Generic;
using System.Linq;
public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int left = 1;
        int right = n;
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (IsBadVersion(mid))
                right = mid;
            else
                left = mid + 1;
        }
        return right;
    }
}