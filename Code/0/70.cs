using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int ClimbStairs(int n)
    {
        if (n == 1)
            return 1;
        else if (n == 2)
            return 2;
        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }

}
