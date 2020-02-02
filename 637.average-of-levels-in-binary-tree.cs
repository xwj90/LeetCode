public class Solution
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var q = new Queue<(TreeNode, int)>();
        q.Enqueue((root, 0));
        var dict = new Dictionary<int, (long, long)>();
        while (q.Any())
        {
            var (item, level) = q.Dequeue();
            if (item != null)
            {
                long sum = item.val;
                long count = 1;
                if (dict.ContainsKey(level))
                {
                    sum += dict[level].Item1;
                    count += dict[level].Item2;
                }
                dict[level] = (sum, count);
                if (item.left != null) q.Enqueue((item.left, level + 1));
                if (item.right != null) q.Enqueue((item.right, level + 1));
            }
        }
        var results = new List<double>();
        for (var i = 0; i <= dict.Keys.Max(); i++)
        {
            if (dict.ContainsKey(i)) results.Add(dict[i].Item1 * 1.0 / dict[i].Item2);
            else results.Add(0.0);
        }
        return results;

    }
}
// @lc code=end

