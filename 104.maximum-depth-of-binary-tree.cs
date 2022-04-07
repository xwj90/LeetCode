/*
 * @lc app=leetcode id=104 lang=csharp
 *
 * [104] Maximum Depth of Binary Tree
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
    public int MaxDepth(TreeNode root)
    {
        var stack = new Stack<(TreeNode node, int depth)>();
        stack.Push((root, 1));
        var max = 0;
        while (stack.Any())
        {
            var (node, depth) = stack.Pop();
            if (node == null)
                continue;
            else
            {
                max = Math.Max(max, depth);
                stack.Push((node.left, depth + 1));
                stack.Push((node.right, depth + 1));
            }
        }
        return max;
    }
}
// @lc code=end

