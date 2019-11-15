/*
 * @lc app=leetcode id=22 lang=csharp
 *
 * [22] Generate Parentheses
 */

// @lc code=start
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var list = new List<string>();
        help("", 0, 0, n, list);
        return list;
    }
    void help(string prefix, int left, int right, int n, List<string> list)
    {
        if (left == n && right == n)
        {
            list.Add(prefix);
            return;
        }

        if (left < n)
            help(prefix + "(", left + 1, right, n, list);
        if (right < left)
            help(prefix + ")", left, right + 1, n, list);
    }
}
// @lc code=end

