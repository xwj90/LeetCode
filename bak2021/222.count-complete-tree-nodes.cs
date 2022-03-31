/*
 * @lc app=leetcode id=222 lang=csharp
 *
 * [222] Count Complete Tree Nodes
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
    public int CountNodes(TreeNode root)
    {
        return root != null ? 1 + CountNodes(root.right) + CountNodes(root.left) : 0;
    }
}
// @lc code=end

