public class Solution
{
    public TreeNode ConstructMaximumBinaryTree(int[] nums)
    {
        var stack = new Stack<TreeNode>();
        for (var i = 0; i < nums.Length; i++)
        {
            var current = new TreeNode(nums[i]);
            while (stack.Any() && stack.Peek().val < nums[i])
            {
                current.left = stack.Pop();
            }
            if (stack.Any())
            {
                stack.Peek().right = current;
            }
            stack.Push(current);
        }

        return stack.Any() ? stack.Last() : null;
    }
}
// @lc code=end

