/*
 * @lc app=leetcode id=921 lang=csharp
 *
 * [921] Minimum Add to Make Parentheses Valid
 */

// @lc code=start
public class Solution
{
    public int MinAddToMakeValid(string S)
    {
        var stack = new Stack<char>();
        foreach (var s in S)
        {
            if (stack.Any())
            {
                var last = stack.Pop();
                if (last == '(' && s == ')')
                {
                    continue;
                }
                else
                {
                    stack.Push(last);
                    stack.Push(s);
                }
            }
            else
            {
                stack.Push(s);
            }
        }
        return stack.Count();

    }
}
// @lc code=end

