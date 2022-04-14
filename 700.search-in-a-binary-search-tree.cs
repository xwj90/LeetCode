/*
 * @lc app=leetcode id=700 lang=csharp
 *
 * [700] Search in a Binary Search Tree
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
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while (root != null)
        {
            if (root.val == val) return root;
            else if (root.val > val) root = root.left;
            else root = root.right;
        }
        return null;
    }
}
// @lc code=end

