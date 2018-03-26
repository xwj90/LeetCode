public partial class Solution
{
    public void Flatten(TreeNode root)
    {
        TreeNode node = null;
        root = Flatten_Get(root, out node);
    }
    private TreeNode Flatten_Get(TreeNode root, out TreeNode bottom)
    {
        if (root == null)
        {
            bottom = null;
            return null;
        }
        TreeNode leftBottom = null;
        TreeNode rightBottom = null;
        var left = Flatten_Get(root.left, out leftBottom);
        var right = Flatten_Get(root.right, out rightBottom);
        var temp = root.right;
        if (root.left != null)
        {
            root.right = root.left;
            root.left = null;
            leftBottom.right = right;
            bottom = right == null ? leftBottom : rightBottom;
        }
        else
        {
            bottom = right == null ? root : rightBottom;
        }
        return root;
    }
}