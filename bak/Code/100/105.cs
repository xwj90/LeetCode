
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        return BuildTree(preorder, inorder, 0, 0, inorder.Length - 1);
    }
    private TreeNode BuildTree(int[] preorder, int[] inorder, int preOrderStart, int inOrderStart, int inOrderEnd)
    {
        if (inOrderEnd < inOrderStart)
            return null;

        TreeNode root = new TreeNode(preorder[preOrderStart]);
        var id = 0;
        for (int i = inOrderStart; i < inorder.Length && i <= inOrderEnd; i++)
            if (inorder[i] == root.val)
            {
                id = i;
                break;
            }

        root.left = BuildTree(preorder, inorder, preOrderStart + 1, inOrderStart, id - 1);
        root.right = BuildTree(preorder, inorder, preOrderStart + id - inOrderStart + 1, id + 1, inOrderEnd);
        return root;

    }

}