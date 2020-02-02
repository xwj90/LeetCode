public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var pValue = p.val;
        var qValue = q.val;
        var node = root;
        while (node != null)
        {
            var parentValue = node.val;
            if (pValue > parentValue && qValue > parentValue) node = node.right;
            else if (pValue < parentValue && qValue < parentValue) node = node.left;
            else return node;
        }
        return null;
    }


}
// @lc code=end

