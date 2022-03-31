using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var values = new int[gas.Length];
        var lend = 0;
        var tank = 0;
        int start = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            tank += gas[i] - cost[i];
            if (tank < 0)
            {
                start = i + 1;
                lend += tank;
                tank = 0;
            }
        }

        return (lend + tank < 0) ? -1 : start;

    }
}