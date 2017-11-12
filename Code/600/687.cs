using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public int LongestUnivaluePath(TreeNode root)
    {
        int length = 0;
        if(root!=null)
            LongestUnivaluePath_Traverse(root, ref length);
        return length;
    }
    int LongestUnivaluePath_Traverse(TreeNode root, ref int length)
    {
        int l = 0, r = 0, resL = 0, resR = 0;
        if (root.left != null)
        {
            l = LongestUnivaluePath_Traverse(root.left, ref length);
            resL = root.left.val == root.val ? l + 1 : 0;
        }
        if (root.right != null)
        {
            r = LongestUnivaluePath_Traverse(root.right, ref length);
            resR = root.right.val == root.val ? r + 1 : 0;
        }
        length = Math.Max(length, resL + resR);
        return Math.Max(resL, resR);
    }
}