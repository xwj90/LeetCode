public class MyQueue
{

    Stack<int> inputStack = new();
    Stack<int> outputStack = new();
    public MyQueue()
    {

    }

    public void Push(int x)
    {
        inputStack.Push(x);
    }

    public int Pop()
    {
        if (!outputStack.Any())
        {

            while (inputStack.Any())
            {
                outputStack.Push(inputStack.Pop());
            }
        }
        return outputStack.Pop();
    }

    public int Peek()
    {
        if (!outputStack.Any())
        {

            while (inputStack.Any())
            {
                outputStack.Push(inputStack.Pop());
            }
        }
        return outputStack.Peek();

    }

    public bool Empty()
    {
        return !(inputStack.Any() || outputStack.Any());
    }
}

// var q = new MyQueue();
// q.Push(1);
// q.Push(2);
// q.Push(3);
// Console.WriteLine(q.Peek());
// Console.WriteLine(q.pop());
