using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{


    TreeNode RecoverTree_First = null;
    TreeNode RecoverTree_Second = null;
    public void RecoverTree(TreeNode root)
    {
        RecoverTree_traverse(root);
    }
    private void RecoverTree_traverse(TreeNode node)
    {
        if (node == null)
            return;
        RecoverTree_traverse(node.left);
        RecoverTree_traverse(node.right);

    }
}