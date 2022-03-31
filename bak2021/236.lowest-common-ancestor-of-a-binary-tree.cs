public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var dict = new Dictionary<TreeNode, TreeNode>();
        dict[root]=null;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var hit = 0;
        while (queue.Any() && hit < 2)
        {
            var item = queue.Dequeue(); 
            if (item.val == p.val) hit++;
            if (item.val == q.val) hit++;
            if (item.left != null)
            {
                dict[item.left] = item;
                queue.Enqueue(item.left);
            }
            if (item.right != null)
            {
                dict[item.right] = item;
                queue.Enqueue(item.right);
            }
        }

        var set = new HashSet<TreeNode>();
        while (p != null)
        {
            set.Add(p);
            p = dict[p];
        }

        while (!set.Contains(q))
        {
            q = dict[q];
        }
        return q;


    }
}
// @lc code=end

