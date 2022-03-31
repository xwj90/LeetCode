public class Solution
{
    int post_idx;
    int[] postorder;
    int[] inorder;
    Dictionary<int, int> idx_map = new Dictionary<int, int>();
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        this.postorder = postorder;
        this.inorder = inorder;
        post_idx = postorder.Length - 1;
        int idx = 0;
        foreach (var v in inorder)
        {
            idx_map[v] = idx++;
        }

        return Helper(0, inorder.Length - 1);

    }
    private TreeNode Helper(int in_left, int in_right)
    {
        if (in_left > in_right)
            return null;

        // pick up post_idx element as a root
        int root_val = postorder[post_idx];
        TreeNode root = new TreeNode(root_val);

        // root splits inorder list
        // into left and right subtrees
        int index = idx_map[root_val];

        // recursion 
        post_idx--;
        // build right subtree
        root.right = Helper(index + 1, in_right);
        // build left subtree
        root.left = Helper(in_left, index - 1);
        return root;
    }
}

