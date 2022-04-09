/*
 * @lc app=leetcode id=513 lang=csharp
 *
 * [513] Find Bottom Left Tree Value
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
    public int FindBottomLeftValue(TreeNode root)
    {
        var currentLevel = 0;
        var val = 0;
        var stack = new Stack<(TreeNode node, int level)>();
        stack.Push((root, 1));
        while (stack.Any())
        {
            var (node, level) = stack.Pop();
            if (node == null) continue;

            if (level > currentLevel)
            {
                currentLevel = level;
                val = node.val;
            }

            stack.Push((node.right, level + 1));
            stack.Push((node.left, level + 1));
        }

        return val;
    }
}
// @lc code=end

