public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        var stack = new Stack<(char c, int id)>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') stack.Push((s[i], i));
            else if (s[i] == ')')
                if (stack.Any() && stack.Peek().c == '(') stack.Pop();
                else stack.Push((s[i], i));
        }
        var status = new bool[s.Length];
        foreach (var (c, id) in stack)
            status[id] = true;

        var res = new List<char>();
        for (var i = 0; i < s.Length; i++)
            if (!status[i]) res.Add(s[i]);
            
        return new string(res.ToArray());
    }
}
// @lc code=end

