public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var res = new List<int>();
        if (root == null) return res;

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Any())
        {
            var node = stack.Pop();
            res.Add(node.val);

            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);
        }

        res.Reverse();
        return res;
    }
}
// @lc code=end

