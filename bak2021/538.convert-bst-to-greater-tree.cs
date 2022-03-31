/*
 * @lc app=leetcode id=538 lang=csharp
 *
 * [538] Convert BST to Greater Tree
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
    public TreeNode ConvertBST(TreeNode root)
    {
        var sum = 0;
        var stack = new Stack<TreeNode>();
        TreeNode node = root;
        while (stack.Any() || node != null)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.right;
            }
            node = stack.Pop();
            sum += node.val;
            node.val = sum;
            node = node.left;
        }
        return root;

        // if (root != null)
        // {
        //     var right = ConvertBST(root.right);
        //     sum += root.val;
        //     root.val = sum;
        //     ConvertBST(root.left);
        // }
        // return root;
    }

}
// @lc code=end

