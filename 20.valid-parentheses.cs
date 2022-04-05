/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution
{
    public bool IsValid(string s)
    {
        var c1 = new char[] { '(', '[', '{' };
        var c2 = new char[] { ')', ']', '}' };
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (c1.Contains(c))
            {
                stack.Push(c);
            }
            else
            {
                if (!stack.Any())
                    return false;
                for (var i = 0; i < c2.Length; i++)
                {
                    if (c2[i] == c)
                    {
                        if (stack.Peek() != c1[i])
                            return false;
                        else
                            stack.Pop();
                    }
                }
            }
        }

        return !stack.Any();
    }
}
// @lc code=end

