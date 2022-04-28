public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        var hs = new List<int>() { 0 };
        hs.AddRange(heights);
        hs.Add(0);

        var stack = new Stack<int>();
        var res = 0;
        for (var i = 0; i < hs.Count; i++)
        {
            while (stack.Any() && hs[stack.Peek()] > hs[i])
            {
                var mid = stack.Pop();
                var left = stack.Peek();
                int w = i - left - 1;
                int h = hs[mid];
                res = Math.Max(res, h * w);

            }
            stack.Push(i);
        }
        return res;
    }
}
// @lc code=end

