
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        var d1 = MinDepth(root.left);
        var d2 = MinDepth(root.right);
        return
            (d1 == 0 || d2 == 0) ? d1 + d2 + 1 : Math.Min(d1, d2) + 1;
    }
}