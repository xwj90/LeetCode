using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int SumNumbers(TreeNode root)
    {        
      return  SumNumbers(root, 0);
    }

    private int SumNumbers(TreeNode n,int s)
    {
        if (n == null) return 0;
        if (n.right == null && n.left == null) return s * 10 + n.val;
        return SumNumbers(n.left, s * 10 + n.val) + SumNumbers(n.right, s * 10 + n.val);
    }
}