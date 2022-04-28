public class Solution
{
    public int Trap(int[] height)
    {

        var stack = new Stack<int>(); 
        var res = 0;
        for (var i = 0; i < height.Length; i++)
        {
            while (stack.Any() && height[i] > height[stack.Peek()])
            {
                var idx = stack.Pop();
                if (stack.Any())
                {
                    var h = Math.Min(height[i], height[stack.Peek()]) - height[idx];
                    var w = i - stack.Peek() - 1;
                    res += h * w;
                }
            }

            stack.Push(i);
            //     Console.WriteLine(res);
        }
        return res;
    }
}
// @lc code=end [4,2,0,3,2,5]

