public class Solution
{
    public int SumEvenGrandparent(TreeNode root)
    {
        var q = new Queue<(TreeNode node, TreeNode parent, TreeNode grandparent)>();
        q.Enqueue((root, null, null));
        var res = 0;

        while (q.Any())
        {
            var item = q.Dequeue();
            if (item.node == null) continue;
            q.Enqueue((item.node.left, item.node, item.parent));
            q.Enqueue((item.node.right, item.node, item.parent));
            if (item.grandparent?.val % 2 == 0) res += item.node.val;
        }
        return res;
    }
}
// @lc code=end

