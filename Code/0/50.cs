using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public double MyPow(double x, int n)
    {
        if (n == 0) return 1;
        else if (n < 0)
            return (n % 2 == 0) ? MyPow(1 / x * 1 / x, -(n / 2)) : 1 / x * MyPow(1 / x * 1 / x, -(n / 2));
        else
            return (n % 2 == 0) ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
    }
}
