/*
 * @lc app=leetcode id=1145 lang=csharp
 *
 * [1145] Binary Tree Coloring Game
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
    int left;
    int right;
    int val;
    public bool BtreeGameWinningMove(TreeNode root, int n, int x)
    {
        val = x;
        count(root);
        return Math.Max(Math.Max(left, right), n - left - right - 1) > n / 2;
    }

    private int count(TreeNode node)
    {
        if (node == null) return 0;
        var l = count(node.left);
        var r = count(node.right);
        if (node.val == val)
        {
            left = l;
            right = r;
        }
        return l + r + 1;
    }
}
// @lc code=end

