public class Solution
{
    public int GetMinimumDifference(TreeNode root)
    {

        var list = new List<int>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Any())
        {
            var item = q.Dequeue();
            if (item != null)
            {
                list.Add(item.val);
                q.Enqueue(item.left);
                q.Enqueue(item.right);
            }
        }
        list = list.OrderBy(p => p).ToList();
        var res = int.MaxValue;
        for (var i = 1; i < list.Count; i++)
        {
            res = Math.Min(res, list[i] - list[i - 1]);
        }
        return res;

    }


}
// @lc code=end

