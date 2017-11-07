using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int Calculate(string s)
    {
        Stack<int> stack = new Stack<int>();
        int number = 0;
        int result = 0;
        int sign = 1;
        foreach (var c in s)
        {
            var v = (c - '0');
            if (v <= 9 && v >= 0)
                number = 10 * number + v;
            else if (c == '+')
            {
                result += sign * number;
                number = 0;
                sign = 1;
            }
            else if (c == '-')
            {
                result += sign * number;
                number = 0;
                sign = -1;
            }
            else if (c == '(')
            {
                stack.Push(result);
                stack.Push(sign);
                sign = 1;
                result = 0;
            }
            else if (c == ')')
            {
                result += sign * number;
                number = 0;
                result *= stack.Pop();//pop up sign
                result += stack.Pop();//pop up result out of ()
            }            
        }
        if (number != 0)
            result += sign * number; //last number 
        return result;
    }
}