public class Solution
{
    public int FindBottomLeftValue(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Any())
        {
            root = q.Dequeue();
            if (root.right != null) q.Enqueue(root.right);
            if (root.left != null) q.Enqueue(root.left);
        }
        return root.val;
    }

}
// @lc code=end

