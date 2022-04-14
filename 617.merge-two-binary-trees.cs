public class Solution
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null) return null;
        var node = new TreeNode((root1 == null ? 0 : root1.val) + (root2 == null ? 0 : root2.val));
        node.left = MergeTrees(root1?.left, root2?.left);
        node.right = MergeTrees(root1?.right, root2?.right);
        return node;
    }
}
// @lc code=end

