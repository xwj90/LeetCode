/*
 * @lc app=leetcode id=863 lang=csharp
 *
 * [863] All Nodes Distance K in Binary Tree
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
    Dictionary<TreeNode, TreeNode> parent = new Dictionary<TreeNode, TreeNode>();
    HashSet<int> results = new HashSet<int>();
    HashSet<TreeNode> seen = new HashSet<TreeNode>();
    public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
    {
        dfs(root, null);
        search(target, K);
        return results.ToList();
    }
    public void search(TreeNode node, int dist)
    {
        if (node == null || seen.Contains(node))
        {

        }
        else if (dist == 0)
        {
            seen.Add(node);
            results.Add(node.val);
        }
        else
        {
            seen.Add(node);
            search(parent[node], dist - 1);
            search(node.left, dist - 1);
            search(node.right, dist - 1);
        }
    }
    public void dfs(TreeNode node, TreeNode par)
    {
        if (node != null)
        {
            parent[node] = par;
            dfs(node.left, node);
            dfs(node.right, node);
        }
    }
}
// @lc code=end


