/*
 * @lc app=leetcode id=515 lang=csharp
 *
 * [515] Find Largest Value in Each Tree Row
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
    public IList<int> LargestValues(TreeNode root)
    {
        var dict = new Dictionary<int, int>();
        var q = new Queue<(TreeNode node, int level)>();
        q.Enqueue((root, 1));
        while (q.Any())
        {
            var (item, level) = q.Dequeue();
            if (item != null)
            {
                if (!dict.ContainsKey(level)) dict[level] = item.val;
                else dict[level] = Math.Max(dict[level], item.val);
                q.Enqueue((item.left, level + 1));
                q.Enqueue((item.right, level + 1));
            }
        }
        return dict.OrderBy(p=>p.Key).Select(p=>p.Value).ToList();
    }
}
// @lc code=end

