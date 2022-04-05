
public class Solution
{
    public string RemoveDuplicates(string s)
    {
        Stack<char> stack = new();
        foreach (var c in s)
            if (stack.Any() && c == stack.Peek())
                stack.Pop();
            else
                stack.Push(c);

        var result = new char[stack.Count];
        var i = stack.Count;
        while (stack.Any())
            result[--i] = stack.Pop();

        return new string(result);

    }
}

