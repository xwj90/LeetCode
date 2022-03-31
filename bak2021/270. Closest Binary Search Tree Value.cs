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
    public int ClosestValue(TreeNode root, double target)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        double minGap = double.MaxValue;
        var res = 0;
        while (q.Any())
        {
            var node = q.Dequeue();
            if (node != null)
            {
                var gap = Math.Abs(node.val - target);
                if (gap < minGap)
                {
                    minGap = gap;
                    res = node.val;
                }

                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }
        }

        return res;
    }
}