using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    int DiameterOfBinaryTree_max = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        DiameterOfBinaryTree_Max(root);
        return DiameterOfBinaryTree_max;
    }
    int DiameterOfBinaryTree_Max(TreeNode root)
    {
        if (root == null) return 0;
        int left = DiameterOfBinaryTree_Max(root.left);
        int right = DiameterOfBinaryTree_Max(root.right);
        DiameterOfBinaryTree_max = Math.Max(DiameterOfBinaryTree_max, left + right);
        return Math.Max(left, right) + 1;
    }
}