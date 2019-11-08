/*
 * @lc app=leetcode id=655 lang=csharp
 *
 * [655] Print Binary Tree
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
    Dictionary<TreeNode, (int, int)> dict = new Dictionary<TreeNode, (int, int)>();
    public IList<IList<string>> PrintTree(TreeNode root)
    {
        bfs(root, 0, 0);
    }
    public void bfs(TreeNode root, int x, int y)
    {
        if (root != null)
        {
            dict[root] = (x, y);
            bfs(root.left, x + 1, y - 1);
            bfs(root.right, x + 1, y + 1);
        }
    }
}
// @lc code=end

