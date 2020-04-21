/*
 * @lc app=leetcode id=227 lang=csharp
 *
 * [227] Basic Calculator II
 */

// @lc code=start
public class Solution
{
    public int Calculate(string s)
    {
        var stack = new Stack<int>();
        var currentValue = 0;
        var sign = '+';
        for (var i = 0; i < s.Length; i++)
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

        return stack.Sum();
    }
}
// @lc code=end

