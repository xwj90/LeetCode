public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        var q = new Queue<(TreeNode, bool)>();
        q.Enqueue((root, false));
        var sum = 0;
        while (q.Any())
        {
            var (item, isLeft) = q.Dequeue();
            if (item == null) continue;
            if (isLeft && item.left == null && item.right == null) sum += item.val;
            if (item.left != null) q.Enqueue((item.left, true));
            if (item.right != null) q.Enqueue((item.right, false));
        }
        return sum;
    }
}
// @lc code=end

