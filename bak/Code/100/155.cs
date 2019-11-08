
using System;
using System.Collections.Generic;
using System.Linq;
public class MinStack
{
    List<int> ls = new List<int>();
    int min = int.MaxValue;
    public void Push(int x)
    {
        min = Math.Min(x, min);
        ls.Add(min);
        ls.Add(x);      
    }

    public void Pop()
    {      
        ls.RemoveRange(ls.Count - 2, 2);
        if (ls.Count > 1)
            min = ls[ls.Count - 2];
        else
            min = int.MaxValue;
    }

    public int Top()
    {
        return ls[ls.Count - 1];
    }

    public int GetMin()
    {
        return min;
    }
}