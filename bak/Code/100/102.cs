using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var ls = new List<IList<int>>();
        LevelOrder(root, 0, ls);
        return ls;
    }
    private void LevelOrder(TreeNode root, int level, List<IList<int>> result)
    {
        if (root == null)
            return;
        if (result.Count <= level)
            result.Add(new List<int>());
        result[level].Add(root.val);
        LevelOrder(root.left, level + 1, result);
        LevelOrder(root.right, level + 1, result);
    }
}