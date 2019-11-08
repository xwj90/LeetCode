using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        List<int> path = new List<int>();
        while (stack.Count > 0 || current != null)
        {
            if (current != null)
            {
                stack.Push(current);
                path.Add(current.val);
                current = current.right;
            }
            else
            {
                current = stack.Pop().left;
            }
        }
        path.Reverse();
        return path;
    }
}