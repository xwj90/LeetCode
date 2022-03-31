using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length <= 1)
            return false;
        Stack<char> q = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (q.Count == 0)
                q.Push(s[i]);
            else if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                q.Push(s[i]);
            else if (s[i] == ')' && q.First() == '(')
                q.Pop();
            else if (s[i] == ']' && q.First() == '[')
                q.Pop();
            else if (s[i] == '}' && q.First() == '{')
                q.Pop();
            else
                return false;
        }
        return q.Count == 0;
    }
}





