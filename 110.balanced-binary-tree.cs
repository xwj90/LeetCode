public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        bool isBalanced = true;
        GetDepth(root, ref isBalanced);
        return isBalanced;
    }
    public int GetDepth(TreeNode root, ref bool isBalanced)
    {
        if (root == null)
            return 0;
        var l = GetDepth(root.left, ref isBalanced);
        var r = GetDepth(root.right, ref isBalanced);
        if (Math.Abs(l - r) > 1)
            isBalanced = false;
        return 1 + Math.Max(l, r);
    }
}
// @lc code=end

