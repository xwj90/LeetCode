
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        List<int> result = new List<int>();
        while(stack.Count>0)
        {
            var node = stack.Pop();
            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
            result.Add(node.val);
        }
        return result;
    }
}