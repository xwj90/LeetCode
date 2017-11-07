using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Codec
{

    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        //In Order Traverse
        var current = root;
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);
        StringBuilder sb = new StringBuilder();
        while(s.Count>0)
        {
            var node = s.Pop();
            sb.Append(node.val + ",");
            if (node.right != null)
                s.Push(node.right);
            if (node.left != null)
                s.Push(node.left);
        }
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {

    }
}
