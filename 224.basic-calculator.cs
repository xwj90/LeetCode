/*
 * @lc app=leetcode id=224 lang=csharp
 *
 * [224] Basic Calculator
 */

// @lc code=start
public class Solution
{
    public int Calculate(string s)
    {
        var stack = new Stack<int>();
        int currentValue = 0;
        int result = 0;
        int sign = 1;
        foreach (var c in s)
        {
            var v = (c - '0');
            if (v <= 9 && v >= 0)
                currentValue = 10 * currentValue + v;
            else if (c == '+')
            {
                result += sign * currentValue;
                currentValue = 0;
                sign = 1;
            }
            else if (c == '-')
            {
                result += sign * currentValue;
                currentValue = 0;
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
                result += sign * currentValue;
                currentValue = 0;
                result *= stack.Pop();//pop up sign
                result += stack.Pop();//pop up result out of ()
            }
        }
        if (currentValue != 0)
            result += sign * currentValue; //last number 
        return result;
    }
}
// @lc code=end

