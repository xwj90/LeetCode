public class Solution
{
    public IList<IList<int>> VerticalOrder(TreeNode root)
    {
        var q = new Queue<(TreeNode Node, int idx)>();
        q.Enqueue((root, 0));

        var dict = new Dictionary<int, IList<int>>();

        while (q.Any())
        {
            var item = q.Dequeue();
            if (item.Node == null) continue;
            if (!dict.ContainsKey(item.idx)) dict[item.idx] = new List<int>();
            dict[item.idx].Add(item.Node.val);
            if (item.Node.left != null) q.Enqueue((item.Node.left, item.idx - 1));
            if (item.Node.right != null) q.Enqueue((item.Node.right, item.idx + 1));
        }

        return dict.OrderBy(p => p.Key).Select(p => p.Value).ToList();
    }
}