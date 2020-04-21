public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return Dep(root) != -1;
    }

    public int Dep(TreeNode root)
    {
        if (root == null) return 0;

        var leftHeight = Dep(root.left);
        if (leftHeight == -1) return -1;
        var rightHeight = Dep(root.right);
        if (rightHeight == -1) return -1;

        if (Math.Abs(leftHeight - rightHeight) > 1) return -1;
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
// @lc code=end

