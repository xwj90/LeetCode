using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> list = new List<string>();
        GenerateParenthesis_AddOne(list, "", 0, 0, n);
        return list;
    }

    private void GenerateParenthesis_AddOne(List<string> list, string s, int open, int close, int max)
    {
        if (s.Length == max * 2)
            list.Add(s);
        else
        {
            if (open < max)
                GenerateParenthesis_AddOne(list, s + "(", open + 1, close, max);
            if (close < open)
                GenerateParenthesis_AddOne(list, s + ")", open, close + 1, max);
        }
    }
}





