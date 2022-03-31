using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{


    TreeNode RecoverTree_First = null;
    TreeNode RecoverTree_Second = null;
    TreeNode RecoverTree_previous = new TreeNode(int.MinValue);
    public void RecoverTree(TreeNode root)
    {
        RecoverTree_traverse(root);

        var temp = RecoverTree_First.val;
        RecoverTree_First.val = RecoverTree_Second.val;
        RecoverTree_Second.val = temp;

    }
    private void RecoverTree_traverse(TreeNode root)
    {
        if (root == null)
            return;

        RecoverTree_traverse(root.left);

        if (RecoverTree_First == null && RecoverTree_previous.val >= root.val)
            RecoverTree_First = RecoverTree_previous;
        if (RecoverTree_First != null && RecoverTree_previous.val >= root.val)
            RecoverTree_Second = root;

        RecoverTree_previous = root;

        RecoverTree_traverse(root.right);

    }
}