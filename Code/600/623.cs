using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public TreeNode AddOneRow(TreeNode root, int v, int d)
    {
        TreeNode fake = new TreeNode(-1);
        fake.left = root;
        Traverse(fake, 1, v, d);
        return fake.left;
    }
    public void Traverse(TreeNode node, int level, int v, int d)
    {
        if (node == null)
            return;
        if (level == d)
        {
            TreeNode leftNode = new TreeNode(v);
            leftNode.left = node.left;
            node.left = leftNode;

            TreeNode rightNode = new TreeNode(v);
            rightNode.right = node.right;
            node.right = rightNode;

        }

        Traverse(node.left, level + 1, v, d);
        Traverse(node.right, level + 1, v, d);
    }
}