using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public int PathSum(TreeNode root, int sum)
    {
        if (root == null)
            return 0;
        var r = 0;
        r += PathSum(root.left, sum - root.val);
        r += PathSum(root.right, sum - root.val);
        r += PathSum(root.left, sum );
        r += PathSum(root.right, sum );
        return r;
    }
}