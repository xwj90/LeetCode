/*
 * @lc app=leetcode id=968 lang=csharp
 *
 * [968] Binary Tree Cameras
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
    int result = 0;
    public int MinCameraCover(TreeNode root)
    {
        if (MinCameraCover1(root) == 0)
            result++;
        return result;

    }

    public int MinCameraCover1(TreeNode root)
    {
        if (root == null)
            return 2;
        var left = MinCameraCover1(root.left);
        var right = MinCameraCover1(root.right);
        if (left == 2 && right == 2) return 0;

        if (left == 0 || right == 0)
        {
            result++;
            return 1;
        }


        if (left == 1 || right == 1) return 2;

        return -1;
    }
}
// @lc code=end

