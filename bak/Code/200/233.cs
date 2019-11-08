using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int CountDigitOne(int n)
    {
        long count = 0;
        for (long m = 1; m <= n; m *= 10)
        {
            count += (n / m + 8) / 10 * m + (n / m % 10 == 1 ? (n % m + 1) : 0);
        }
        return Convert.ToInt32(count);
    }
}