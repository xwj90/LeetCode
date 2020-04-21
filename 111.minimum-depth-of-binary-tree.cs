/*
 * @lc app=leetcode id=111 lang=csharp
 *
 * [111] Minimum Depth of Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if(root==null) return 0;
        var v = int.MaxValue;
        if (root.left != null) v = Math.Min(v, 1 + MinDepth(root.left));
        if (root.right != null) v = Math.Min(v, 1 + MinDepth(root.right));
        if (root.left == null && root.right == null) return 1;
        return v;
    }
}
// @lc code=end

