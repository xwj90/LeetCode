/*
 * @lc app=leetcode id=102 lang=csharp
 *
 * [102] Binary Tree Level Order Traversal
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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var res = new List<IList<int>>();
        if (root == null)
            return res;

        var stack = new Stack<(TreeNode node, int level)>();
        stack.Push((root, 0));

        while (stack.Any())
        {
            var (node, level) = stack.Pop();
            if (level == res.Count)
                res.Add(new List<int>());
            res[level].Add(node.val);
            if (node.right != null)
                stack.Push((node.right, level + 1));
            if (node.left != null)
                stack.Push((node.left, level + 1));
        }
        return res;
    }
}
// @lc code=end

