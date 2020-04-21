/*
 * @lc app=leetcode id=105 lang=csharp
 *
 * [105] Construct Binary Tree from Preorder and Inorder Traversal
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    int[] preorder;
    int[] inorder;
    int pre_idx;
    Dictionary<int, int> map = new Dictionary<int, int>();
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        this.inorder = inorder;
        this.preorder = preorder;
        for (var i = 0; i < inorder.Length; i++)
        {
            map[inorder[i]] = i;
        }
        return helper(0, inorder.Length);
    }
    private TreeNode helper(int left, int right)
    {
        if (left == right) return null;
        var root_val = preorder[pre_idx];
        var root = new TreeNode(root_val);
        var inorder_index = this.map[root_val];
        pre_idx++;
        root.left = helper(left, inorder_index);
        root.right = helper(inorder_index + 1, right);
        return root;
    }
}

// @lc code=end

