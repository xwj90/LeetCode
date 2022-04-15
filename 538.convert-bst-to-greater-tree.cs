public class Solution
{
    public TreeNode ConvertBST(TreeNode root)
    {
        var current = root;
        var stack = new Stack<TreeNode>();
        var sum = 0;
        while (current != null || stack.Any())
        {
            if (current != null)
            {
                stack.Push(current);
                current = current.right;
            }
            else
            {
                var node = stack.Pop();
                node.val += sum;
                sum = node.val;
                current = node.left;
            }
        }
        return root;
    }
}
// @lc code=end

