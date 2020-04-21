/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */

// @lc code=start
public class MinStack
{

    /** initialize your data structure here. */
    Stack<(int value, int min)> stack = new Stack<(int value, int min)>();
    public MinStack()
    {

    }

    public void Push(int x)
    {
        var min = x;
        if (stack.Any())
            min = Math.Min(min, stack.Peek().min);
        stack.Push((x, min));
    }

    public void Pop()
    {
        stack.Pop();
    }

    public int Top()
    {
        return stack.Peek().value;
    }

    public int GetMin()
    {
        return stack.Peek().min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

