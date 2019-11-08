using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public IList<int> InorderTraversal(TreeNode node)
    {
        List<int> result = new List<int>();
        Stack<TreeNode> nodes = new Stack<TreeNode>() ;
        while (nodes.Count > 0 ||node!=null )
        {
            if(node!=null)
            {
                nodes.Push(node);
                node = node.left;
            }
          else
            {
                node = nodes.Pop();
                result.Add(node.val);
                node = node.right;
            }
        }
        return result;
    }
}