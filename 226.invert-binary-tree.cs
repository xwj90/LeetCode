public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;
        var temp = root.right;
        root.right = root.left;
        root.left = temp;

        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}
// @lc code=end

