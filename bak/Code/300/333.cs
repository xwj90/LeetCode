using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public int LargestBSTSubtree(TreeNode root)
    {
        if (root == null) return 0;
        if (root.left == null && root.right == null) return 1;
        if (LargestBSTSubtree_IsValid(root, null, null)) return LargestBSTSubtree_CountNode(root);
        return Math.Max(LargestBSTSubtree(root.left), LargestBSTSubtree(root.right));
    }

    private int LargestBSTSubtree_CountNode(TreeNode root)
    {
        if (root == null) return 0;
        return 1 + LargestBSTSubtree_CountNode(root.left) + LargestBSTSubtree_CountNode(root.right);
    }

    private bool LargestBSTSubtree_IsValid(TreeNode root, int? min, int? max)
    {
        if (root == null) return true;
        if (min != null && min >= root.val) return false;
        if (max != null && max <= root.val) return false;
        return LargestBSTSubtree_IsValid(root.left, min, root.val) && LargestBSTSubtree_IsValid(root.right, root.val, max);
    }

}