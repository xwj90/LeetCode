public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null) return root;
        if (root.val > p.val && root.val > q.val)
            return LowestCommonAncestor(root.left, p, q);
        if (root.val < p.val && root.val < q.val)
            return LowestCommonAncestor(root.right, p, q);
        return root;

    }
}
// @lc code=end

