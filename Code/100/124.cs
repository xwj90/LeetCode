using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    int MaxPathSum_maxValue = int.MinValue;
    public int MaxPathSum(TreeNode root)
    {
        MaxPathSum_maxValue = root.val;
        MaxPathSum_traverse(root);
        return MaxPathSum_maxValue;
    }
    int MaxPathSum_traverse(TreeNode node)
    {
        var v = 0;
        var maxPath = 0;
        if (node == null)
            return 0;
        else if (node.left == null && node.right == null)
        {
            maxPath = node.val;
            v = node.val;
        }
        else
        {
            var maxLeft = Math.Max(0, MaxPathSum_traverse(node.left));
            var maxRight = Math.Max(0, MaxPathSum_traverse(node.right));
            maxPath = Math.Max(0, node.val + Math.Max(maxLeft, maxRight));
            v = node.val + maxLeft + maxRight;
        }
        MaxPathSum_maxValue = Math.Max(MaxPathSum_maxValue, v);
        return maxPath;
    }
}