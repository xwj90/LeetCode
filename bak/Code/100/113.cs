using System.Collections.Generic;

public partial class Solution
{
    public IList<IList<int>> PathSum(TreeNode root, int sum)
    {
        var result = new List<IList<int>>();
        var path = new List<int>();
        PathSum(root, sum, path, result);
        return result;
    }
    private void PathSum(TreeNode root, int sum, List<int> path, IList<IList<int>> result)
    {
        if (root == null)
            return;
        else if (root.left == null && root.right == null && root.val == sum)
        {
            var r = new List<int>(path);
            r.Add(root.val);
            result.Add(r);
        }
        else
        {
            path.Add(root.val);
            PathSum(root.left, sum - root.val, path, result);
            PathSum(root.right, sum - root.val, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}