
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        var leftDepth = MaxDepth(root.left);
        var rightDepth = MaxDepth(root.right);
        return Math.Max(leftDepth, rightDepth) + 1;
    }
}