public class Solution
{

    public IList<int> RightSideView(TreeNode root)
    {
        var level = new Dictionary<int, int>();
        var q = new Queue<(TreeNode node, int level)>();
        q.Enqueue((root, 1));
        while (q.Any())
        {
            var (node, l) = q.Dequeue();
            if (node != null)
            {
                if (!level.ContainsKey(l)) level[l] = node.val;
                if (node.right != null) q.Enqueue((node.right, l + 1));
                if (node.left != null) q.Enqueue((node.left, l + 1));
            }
        }
        return level.OrderBy(p => p.Key).Select(p => p.Value).ToList();
    }

}
// @lc code=end

