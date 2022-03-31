using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public bool JudgeCircle(string moves)
    {
        int x = 0;
        int y = 0;
        foreach (var n in moves)
        {
            switch(n)
            {
                case 'R':
                    {
                        y++; break;
                    }
                case 'L':
                    {
                        y--; break;
                    }
                case 'U':
                    {
                        x++; break;
                    }
                case 'D':
                default:
                    {
                        x--; break;
                    }
            }         
        }
        return x == 0 && y == 0;
    }
}