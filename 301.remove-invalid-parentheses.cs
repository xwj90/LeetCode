public class Solution
{
    public IList<string> RemoveInvalidParentheses(string s)
    {
        var cs = s.ToCharArray();
        var maxRemove = Valid(cs);
        var res = new HashSet<string>();
        DFS(cs, 0, maxRemove, res);
        return res.ToList();
    }
    private void DFS(char[] cs, int start, int reminder, HashSet<string> results)
    {
        if (reminder == 0 && Valid(cs) == 0)
            results.Add(new string(cs.Where(p => p != ' ').ToArray()));
        else if (reminder >= 0 && start  < cs.Length)
        {
            DFS(cs, start + 1, reminder, results);
            var c = cs[start];
            if (c == '(' || c == ')')
            {
                cs[start] = ' ';
                DFS(cs, start + 1, reminder - 1, results);
                cs[start] = c;
            }
        }
    }

    private int Valid(char[] cs)
    {
        var beRemoved = 0;
        var left = 0;
        foreach (var c in cs)
        {
            if (c == '(') left++;
            else if (c == ')' && left > 0) left--;
            else if (c == ')') beRemoved++;
        }
        beRemoved += left;
        return beRemoved;
    }
}
// @lc code=end

