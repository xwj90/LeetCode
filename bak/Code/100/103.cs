using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var ls = new List<IList<int>>();
        ZigzagLevelOrder(root, 0, ls);
        for (int i = 1; i < ls.Count; i += 2)
        {
            ls[i] = ls[i].Reverse().ToList();
        }
        return ls;
    }
    private void ZigzagLevelOrder(TreeNode root, int level, List<IList<int>> result)
    {
        if (root == null)
            return;
        if (result.Count <= level)
            result.Add(new List<int>());
        result[level].Add(root.val);
        ZigzagLevelOrder(root.left, level + 1, result);
        ZigzagLevelOrder(root.right, level + 1, result);
    }
}