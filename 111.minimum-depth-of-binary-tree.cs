public class Solution
{
    public int MinDepth(TreeNode root)
    {
        var stack = new Stack<(TreeNode node, int depth)>();
        stack.Push((root, 1));
        var min = int.MaxValue;
        while (stack.Any())
        {
            var (node, depth) = stack.Pop();
            if (node == null)
                continue;
            if (node.left == null && node.right == null)
                min = Math.Min(min, depth);
            else
            {
                stack.Push((node.left, depth + 1));
                stack.Push((node.right, depth + 1));
            }
        }
        return min == int.MaxValue ? 0 : min;
    }
}
// @lc code=end

