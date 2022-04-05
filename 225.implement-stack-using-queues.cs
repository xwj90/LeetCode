/*
 * @lc app=leetcode id=225 lang=csharp
 *
 * [225] Implement Stack using Queues
 */

// @lc code=start
public class MyStack
{

    Queue<int> q = new();
    Queue<int> q2 = new();
    int Last = -1;
    public MyStack()
    {

    }

    public void Push(int x)
    {
        this.q.Enqueue(x);
        this.Last = x;
    }

    public int Pop()
    {
        if (q.Count == 1)
        {
            return q.Dequeue();
        }

        while (q.Count > 1)
        {
            var v = q.Dequeue();
            this.Last = v;
            q2.Enqueue(v);
        }

        var res = q.Dequeue();
        var temp = q2;
        q2 = q;
        q = temp;

        return res;
    }

    public int Top()
    {
        return this.Last;
    }

    public bool Empty()
    {
        return !this.q.Any();
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

