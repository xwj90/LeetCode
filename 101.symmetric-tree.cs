/*
 * @lc app=leetcode id=101 lang=csharp
 *
 * [101] Symmetric Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        return IsSymmetric(root.left, root.right);
    }

    public bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
            return true;
        if (left?.val == right?.val)
        {
            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
        return false;

    }
}
// @lc code=end

