public class Solution
{
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null)
            return root;

        if (root.val > key)
            root.left = DeleteNode(root.left, key);
        else if (root.val < key)
            root.right = DeleteNode(root.right, key);
        else
        {
            if (root.left != null && root.right != null)
            {
                var cur = root.right;
                while (cur.left != null)
                    cur = cur.left;

                cur.left = root.left;
                return root.right;
            }
            else
            {
                return root.left ?? root.right;
            }
        }

        return root;
    }
}
// @lc code=end

