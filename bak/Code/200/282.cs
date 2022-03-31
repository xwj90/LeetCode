using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<string> AddOperators(string num, int target)
    {
        List<string> s = new List<string>();
        if (num == null || num.Length == 0) return s;
        AddOperators_Loop(s, "", num, target, 0, 0, 0);
        return s;
    }

    private void AddOperators_Loop(List<string> s, string path, string num, int target, int pos, long eval, long multed)
    {
        if (pos == num.Length)
        {
            if (target == eval)
                s.Add(path);
            return;
        }
        for (int i = pos; i < num.Length; i++)
        {
            if (i != pos && num[pos] == '0') break;
            long cur = Convert.ToInt64(num.Substring(pos, i + 1 - pos));
            if (pos == 0)
            {
                AddOperators_Loop(s, path + cur, num, target, i + 1, cur, cur);
            }
            else
            {
                AddOperators_Loop(s, path + "+" + cur, num, target, i + 1, eval + cur, cur);
                AddOperators_Loop(s, path + "-" + cur, num, target, i + 1, eval - cur, -cur);
                AddOperators_Loop(s, path + "*" + cur, num, target, i + 1, eval - multed + multed * cur, multed * cur);
            }
        }
    }
}