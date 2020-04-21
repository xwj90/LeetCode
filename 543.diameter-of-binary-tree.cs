public class Solution
{
    int ans = 1;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        ans = 1;
        Depth(root);
        return ans - 1;
    }
    public int Depth(TreeNode root)
    {
        if (root == null) return 0;
        var l = Depth(root.left);
        var r = Depth(root.right);
        ans = Math.Max(ans, l + r + 1);
        return Math.Max(l, r) + 1;

    }

}
// @lc code=end

