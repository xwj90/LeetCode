public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {

        var res = new List<int>();

        var stack = new Stack<TreeNode>();
        var current = root;
        while (current != null || stack.Any())
        {
            if (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            else
            {
                current = stack.Pop();
                res.Add(current.val);
                current = current.right;
            }
        }
        return res;
    }
}
// @lc code=end

