public class Solution
{
    public int GetMinimumDifference(TreeNode root)
    {
        TreeNode prev = null;
        int min = int.MaxValue;
        PreOrder(root, ref prev, ref min);
        return min;
    }
    public void PreOrder(TreeNode root, ref TreeNode prev, ref int min)
    {
        if (root == null) return;
        PreOrder(root.left, ref prev, ref min);
        if (prev != null)
            min = Math.Min(min, root.val - prev.val);
        prev = root;
        PreOrder(root.right, ref prev, ref min);
    }
}
// @lc code=end
// [1,0,48,null,null,12,49]
