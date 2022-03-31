using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int CountPrimes(int n)
    {
        bool[] status = new bool[n];
        int count = 0;
        for (int i = 2; i < n; i++)
        {
            if (!status[i])
                count++;
            for (int j = 2;  i*j<n; j++)
            {
                status[i * j] = true;
            }
        }
        return count;
    }

}