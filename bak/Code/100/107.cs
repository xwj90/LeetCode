
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        var result = new List<IList<int>>();
        LevelOrderBottom(root, 0, result);
        result.Reverse();
        return result;
    }
    private void LevelOrderBottom(TreeNode root, int level, IList<IList<int>> result)
    {
        if (root == null)
            return;
        if (result.Count <= level)
            result.Add(new List<int>());
        result[level].Add(root.val);
        LevelOrderBottom(root.left, level + 1, result);
        LevelOrderBottom(root.right, level + 1, result);
    }

}