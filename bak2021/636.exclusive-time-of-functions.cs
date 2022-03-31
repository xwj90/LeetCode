public class Solution
{
    public int[] ExclusiveTime(int n, IList<string> logs)
    {
        var results = new int[n];
        var stack = new Stack<int>();
        var (id, status, time) = Analyze(logs[0]);
        stack.Push(id);
        int i = 0;
        var prev = time;
        while (i < logs.Count)
        {
            (id, status, time) = Analyze(logs[i]);
            if (status == "start")
            {
                if (stack.Any()) results[stack.Peek()] += time - prev;
                stack.Push(id);
                prev = time;
            }
            else
            {
                results[stack.Peek()] += time - prev + 1;
                stack.Pop();
                prev = time + 1;
            }
            i++;
        }
        return results;
    }


    private (int, string, int) Analyze(string s)
    {
        var a = s.Split(':');
        var id = Convert.ToInt32(a[0]);
        var time = Convert.ToInt32(a[2]);
        return (id, a[1], time);
    }
}
// @lc code=end

