/*
 * @lc app=leetcode id=112 lang=csharp
 *
 * [112] Path Sum
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
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        var stack = new Stack<(TreeNode node, int sum)>();
        stack.Push((root, 0));
        while (stack.Any())
        {
            var (node, sum) = stack.Pop();

            if (node == null) continue;
            if (node.val + sum == targetSum && node.left == null && node.right == null) return true;

            stack.Push((node.left, node.val + sum));
            stack.Push((node.right, node.val + sum));

        }
        return false;
    }
}
// @lc code=end

