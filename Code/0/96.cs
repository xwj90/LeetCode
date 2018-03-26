using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public int NumTrees(int n)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        return NumTrees( 1, n, dict);
    }
    private int NumTrees( int min, int max, Dictionary<int,int> dict)
    {
        if (dict.ContainsKey(max - min))
            return dict[max - min];
        if (min >= max)
            return 1;
        var c = 0;
        for (int i = min; i <= max; i++)
            c += NumTrees(min, i - 1,dict) * NumTrees(i + 1, max,dict);
        dict[max - min] = c;
        return c;
    }
}