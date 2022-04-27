public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var results = new int[temperatures.Length];
        var stack = new Stack<int>();
        stack.Push(0);
        for (var i = 1; i < temperatures.Length; i++)
        {

            while (stack.Any() && temperatures[i] > temperatures[stack.Peek()])
            {
                results[stack.Peek()] = i - stack.Pop();
            }

            stack.Push(i);
        }
        return results;
    }
}
// @lc code=end

