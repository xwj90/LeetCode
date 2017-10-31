using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0 || dividend == int.MinValue)
            return int.MaxValue;
        return Convert.ToInt32(Math.Pow(2, Math.Log(dividend) - Math.Log(divisor)));
    }
}





