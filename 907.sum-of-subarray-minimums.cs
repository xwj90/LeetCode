
public class Solution
{
    public int SumSubarrayMins(int[] A)
    {
        var mod = 1000000007;
        var stack = new Stack<(int val, int count)>();
        var ans = 0;
        var dot = 0;
        for (var j = 0; j < A.Length; j++)
        {
            var count = 1;
            while (stack.Any() && stack.Peek().val >= A[j])
            {
                var node = stack.Pop();
                count += node.count;
                dot -= node.val * node.count;
            }
            stack.Push((A[j], count));
            dot += A[j] * count;
            ans += dot;
            ans %= mod;
        }
        return ans;
    }
}
// @lc code=end

