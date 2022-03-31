/*
 * @lc app=leetcode id=993 lang=csharp
 *
 * [993] Cousins in Binary Tree
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
    public bool IsCousins(TreeNode root, int x, int y)
    {

        var q = new Queue<(TreeNode node, TreeNode parent, int depth)>();
        q.Enqueue((root, null, 0));

        TreeNode xParent=null;
        TreeNode yParent=null;
        int xDepth=int.MaxValue;
        int yDepth=int.MinValue;

        while (q.Any())
        {
            var (node, parent, depth) = q.Dequeue();
            if (node != null)
            {
                q.Enqueue((node.left, node, depth + 1));
                q.Enqueue((node.right, node, depth + 1));
                if (node.val == x)
                {
                    xParent = parent;
                    xDepth = depth;
                }
                if (node.val == y)
                {
                    yParent = parent;
                    yDepth = depth;
                }
            }
        }

        if (xParent != yParent && x != y && yDepth == xDepth)
            return true;

        return false;
    }
}
// @lc code=end

