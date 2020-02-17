/*
 * @lc app=leetcode id=230 lang=csharp
 *
 * [230] Kth Smallest Element in a BST
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
    public int KthSmallest(TreeNode root, int k)
    {
        var s = new Stack<TreeNode>();
        while (true)
        {
            while (root != null)
            {
                s.Push(root);
                root = root.left;
            }
            root = s.Pop();
            if (--k == 0) return root.val;
            root = root.right;
        }
    }
}
// @lc code=end

