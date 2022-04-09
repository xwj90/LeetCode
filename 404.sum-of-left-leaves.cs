/*
 * @lc app=leetcode id=404 lang=csharp
 *
 * [404] Sum of Left Leaves
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
    public int SumOfLeftLeaves(TreeNode root)
    {
        var stack = new Stack<(TreeNode node, bool isLeft)>();
        stack.Push((root, false));
        var sum = 0;
        while (stack.Any())
        {
            var (node, isLeft) = stack.Pop();

            if (node == null) continue;
            if (isLeft && node.left == null && node.right == null)
                sum += node.val;
            stack.Push((node.left, true));
            stack.Push((node.right, false));
        }
        return sum;
    }
}
// @lc code=end

