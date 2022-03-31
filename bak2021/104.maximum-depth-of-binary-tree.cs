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
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public int MaxDepth(TreeNode root)
    {

        var q = new Queue<(TreeNode, int)>();
        q.Enqueue((root, 1));
        var maxLevel = 0;
        while (q.Any())
        {
            var (node, level) = q.Dequeue();
            if (node != null)
            {
                maxLevel = Math.Max(maxLevel, level);
                if (node.left != null) q.Enqueue((node.left, level + 1));
                if (node.right != null) q.Enqueue((node.right, level + 1));
            }
        }
        return maxLevel;
    }
}
// @lc code=end

