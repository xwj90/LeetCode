/*
 * @lc app=leetcode id=1305 lang=csharp
 *
 * [1305] All Elements in Two Binary Search Trees
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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
    {
        var stack1 = new Stack<TreeNode>();
        var stack2 = new Stack<TreeNode>();
        var res = new List<int>();

        while (root1 != null || root2 != null || stack1.Any() || stack2.Any())
        {
            while (root1 != null)
            {
                stack1.Push(root1);
                root1 = root1.left;
            }

            while (root2 != null)
            {
                stack2.Push(root2);
                root2 = root2.left;
            }

            if (!stack2.Any() || stack1.Any() && stack1.First().val <= stack2.First().val)
            {
                root1 = stack1.Pop();
                res.Add(root1.val);
                root1 = root1.right;
            }
            else
            {
                root2 = stack2.Pop();
                res.Add(root2.val);
                root2 = root2.right;
            }
        }
        return res;

    }

}
// @lc code=end

