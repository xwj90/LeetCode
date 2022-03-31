/*
 * @lc app=leetcode id=450 lang=csharp
 *
 * [450] Delete Node in a BST
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
    public int successor(TreeNode root)
    {
        root = root.right;
        while (root.left != null) root = root.left;
        return root.val;
    }

    public int predecessor(TreeNode root)
    {
        root = root.left;
        while (root.right != null) root = root.right;
        return root.val;
    }
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null) return null;

        if (key > root.val) root.right = DeleteNode(root.right, key);
        else if (key < root.val) root.left = DeleteNode(root.left, key);
        else
        {
            if (root.left == null && root.right == null) root = null;
            else if (root.right != null)
            {
                root.val = successor(root);
                root.right = DeleteNode(root.right, root.val);
            }
            else
            {
                root.val = predecessor(root);
                root.left = DeleteNode(root.left, root.val);
            }
        }
        return root;
    }
}
// @lc code=end

