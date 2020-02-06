/*
 * @lc app=leetcode id=938 lang=csharp
 *
 * [938] Range Sum of BST
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
    public int RangeSumBST(TreeNode root, int L, int R)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var sum = 0;
        while (q.Any())
        {
            var item = q.Dequeue();
            if (item != null)
            {
                if (item.val >= L && item.val <= R) sum += item.val;
                q.Enqueue(item.left);
                q.Enqueue(item.right);
            }
        }
        return sum;
    }
}
// @lc code=end

