public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (var s in tokens)
        {
            if (int.TryParse(s, out var num))
            {
                stack.Push(num);
            }
            else
            {
                var v2 = stack.Pop();
                var v1 = stack.Pop();
                if (s == "+")
                    v1 += v2;
                else if (s == "-")
                    v1 -= v2;
                else if (s == "*")
                    v1 *= v2;
                else
                    v1 /= v2;
                stack.Push(v1);
            }
        }
        return stack.Pop();
    }
}
// @lc code=end

