using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, long.MinValue, long.MaxValue);
    }
    public bool IsValidBST(TreeNode root, long min, long max)
    {
        if (root == null)
            return true;
        if (root.val <= min || root.val >= max)
            return false;
        if (root.left != null && root.left.val >= root.val)
            return false;
        if (root.right != null && root.right.val <= root.val)
            return false;
        return IsValidBST(root.left, min, Math.Min(root.val, max)) && IsValidBST(root.right, Math.Max(root.val, min), max);
    }
}