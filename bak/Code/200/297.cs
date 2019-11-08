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
        StringBuilder sb = new StringBuilder();
        serialize_Build(root, sb);
        return sb.ToString();
    }
    string Null = ".";
    char Spliter = ',';
    void serialize_Build(TreeNode node, StringBuilder sb)
    {
        if (node == null)
            sb.Append(Null).Append(Spliter);
        else
        {
            sb.Append(node.val).Append(Spliter);
            serialize_Build(node.left, sb);
            serialize_Build(node.right, sb);
        }
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        var d = data.Split(new char[] { Spliter }, StringSplitOptions.RemoveEmptyEntries);
        Queue<string> q = new Queue<string>(d);
        return deserialize_Build(q);
    }
    TreeNode deserialize_Build(Queue<string> q)
    {
        var v = q.Dequeue();
        if (v == Null)
            return null;
        else
        {
            var t = new TreeNode(Convert.ToInt32(v));
            t.left = deserialize_Build(q);
            t.right = deserialize_Build(q);
            return t;
        }
    }
}
