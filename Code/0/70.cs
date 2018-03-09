using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int ClimbStairs(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        int step1 = 1;
        int step2 = 2;
        for (int i = 3; i <= n; i++)
        {
            var step = step1 + step2;
            step1 = step2;
            step2 = step;
        }
        return step2;
    }

}
