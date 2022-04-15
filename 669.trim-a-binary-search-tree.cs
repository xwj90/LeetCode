public class Solution
{
    public TreeNode TrimBST(TreeNode root, int low, int high)
    {
        if (root == null) return null;

        if (root.val >= low && root.val <= high)
        {
            root.left = TrimBST(root.left, low, high);
            root.right = TrimBST(root.right, low, high);
            return root;
        }
        else if (root.val < low)
        {
            return TrimBST(root.right, low, high);
        }
        else
        {
            return TrimBST(root.left, low, high);
        }
    }
}

