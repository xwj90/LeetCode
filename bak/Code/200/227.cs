using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution1
{
    /// <summary>
    /// 227. Basic Calculator II
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int Calculate(string s)
    {
        Stack<int> stack = new Stack<int>();
        var currentValue = 0;
        char sign = '+';
        for (int i = 0; i < s.Length; i++)  
        {
            if (s[i] >= '0' && s[i] <= '9')
                currentValue = currentValue * 10 + (s[i] - '0');
            if ((s[i] != ' ' && (s[i] < '0' || s[i] > '9')) || i == s.Length - 1)
            {
                if (sign == '+')
                    stack.Push(currentValue);
                else if (sign == '-')
                    stack.Push(-currentValue);
                else if (sign == '*')
                    stack.Push(stack.Pop() * currentValue);
                else if (sign == '/')
                    stack.Push(stack.Pop() / currentValue);
                sign = s[i];
                currentValue = 0;
            }
        }
        int re = 0;
        foreach (var v in stack)
        {
            re += v;
        }
        return re;
    }
}