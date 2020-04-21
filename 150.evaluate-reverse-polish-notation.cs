public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var st = new Stack<int>();
        foreach (var t in tokens)
        {
            if (t == "+") st.Push(st.Pop() + st.Pop());
            else if (t == "-") st.Push(-st.Pop() + st.Pop());
            else if (t == "*") st.Push(st.Pop() * st.Pop());
            else if (t == "/") st.Push((int)Math.Truncate(1.0 / st.Pop() * st.Pop()));
            else st.Push(Convert.ToInt32(t));
        }
        return st.Pop();
    }
}

