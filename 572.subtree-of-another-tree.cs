public class Solution
{
    public bool IsSubtree(TreeNode s, TreeNode t)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(s);
        var candidates = new List<TreeNode>();
        while (q.Any())
        {
            var item = q.Dequeue();
            if (item != null)
            {
                if (item.val == t.val) candidates.Add(item);
                if (item.left != null) q.Enqueue(item.left);
                if (item.right != null) q.Enqueue(item.right);
            }
        }
        foreach (var item in candidates)
        {
            if (Same(item, t)) return true;
        }
        return false;
    }
    private bool Same(TreeNode s, TreeNode t)
    {
        if (s == null && t == null) return true;
        if (s == null && t != null) return false;
        if (s != null && t == null) return false;
        if (s != null && t != null & s.val != t.val) return false;
        return Same(s.left, t.left) && Same(s.right, t.right);
    }
}
// @lc code=end

