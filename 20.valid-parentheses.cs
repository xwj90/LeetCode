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
        var q = new Stack<char>();
        foreach (var c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                q.Push(c);
            }
            else if (c == ')')
            {
                if (q.Count == 0 || q.Pop() != '(')
                    return false;
            }
            else if (c == ']')
            {
                if (q.Count == 0 || q.Pop() != '[')
                    return false;
            }
            else if (c == '}')
            {
                if (q.Count == 0 || q.Pop() != '{')
                    return false;
            }
        }
        return q.Count == 0;
    }
}
// @lc code=end

