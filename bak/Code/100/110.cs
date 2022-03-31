
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public bool IsBalanced(TreeNode root)
    {
        var s = true;
        var d = IsBalanced_Depth(root, ref s);
        return s;
    }
    private int IsBalanced_Depth(TreeNode root, ref bool isbalance)
    {
        if (root == null) return 0;
        var d1 = IsBalanced_Depth(root.left, ref isbalance);
        var d2 = IsBalanced_Depth(root.right, ref isbalance);
        if (Math.Abs(d1 - d2) > 1)
            isbalance = false;
        return Math.Max(d1, d2) + 1;
    }
}