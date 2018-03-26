using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        else if (p == null || q == null)
            return false;
        else
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}