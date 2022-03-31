/*
 * @lc app=leetcode id=687 lang=csharp
 *
 * [687] Longest Univalue Path
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
    public int LongestUnivaluePath(TreeNode root)
    {
        var parent = new Dictionary<int, int>();
        var nodeCount = new Dictionary<int, int>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Any())
        {
            var item = q.Dequeue();
        }

    }
}
// @lc code=end

