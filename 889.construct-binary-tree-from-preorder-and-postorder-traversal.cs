/*
 * @lc app=leetcode id=889 lang=csharp
 *
 * [889] Construct Binary Tree from Preorder and Postorder Traversal
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

    public TreeNode ConstructFromPrePost(int[] pre, int[] post)
    {
        return make(0, 0, pre.Length, pre, post);
    }
    public TreeNode make(int i0, int i1, int N, int[] pre, int[] post)
    {
        if (N == 0) return null;
        var root = new TreeNode(pre[i0]);
        if (N == 1) return root;

        var L = 1;
        for (; L < N; ++L)
            if (post[i1 + L - 1] == pre[i0 + 1])
                break;
        root.left = make(i0 + 1, i1, L, pre, post);
        root.right = make(i0 + L + 1, i1 + L, N - 1 - L, pre, post);
        return root;
    }
}
// @lc code=end

