using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int LongestValidParentheses(string s)
    {
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                stack.Push(i);
            else if (stack.Count > 0 && s[stack.First()] == '(')
                stack.Pop();
            else
                stack.Push(i);
        }
        if (stack.Count == 0)
            return s.Length;
        var max = 0;
        var last = s.Length;
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            max = Math.Max(max, last - current - 1);
            last = current;
        }
        max = Math.Max(max, last - 0);
        return max;
    }
}
