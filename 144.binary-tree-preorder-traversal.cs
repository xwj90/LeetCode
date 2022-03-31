/*
 * @lc app=leetcode id=144 lang=csharp
 *
 * [144] Binary Tree Preorder Traversal
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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var res = new List<int>();

        if (root == null)
        {
            return res;
        }

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Any())
        {
            var node = stack.Pop();
            res.Add(node.val);
            if (node.right != null)
                stack.Push(node.right);
            if (node.left != null)
                stack.Push(node.left);
        }
        return res;
        
    }
}
// @lc code=end

