
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        return BuildTree(inorder, postorder, postorder.Length - 1, 0, inorder.Length - 1);
    }
    private TreeNode BuildTree(int[] inorder, int[] postorder, int postOrderId, int inOrderStart, int inOrderEnd)
    {
        if (inOrderEnd < inOrderStart)
            return null;

        TreeNode root = new TreeNode(postorder[postOrderId]);
        var id = 0;
        for (int i = inOrderStart; i < inorder.Length && i <= inOrderEnd; i++)
            if (inorder[i] == root.val)
            {
                id = i;
                break;
            }

        root.left = BuildTree(inorder, postorder, postOrderId - inOrderEnd + id - 1, inOrderStart, id - 1);
        root.right = BuildTree(inorder, postorder, postOrderId - 1, id + 1, inOrderEnd);
        return root;

    }

}