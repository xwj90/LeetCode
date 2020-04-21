/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;

    public Node() {}

    public Node(int _val) {
        val = _val;
        left = null;
        right = null;
    }

    public Node(int _val,Node _left,Node _right) {
        val = _val;
        left = _left;
        right = _right;
    }
}
*/

public class Solution
{
    Node head;
    Node last;
    public Node TreeToDoublyList(Node root)
    {
        if (root == null) return null;
        Traverse(root);
        last.right = head;
        head.left = last;
        return head;
    }

    public void Traverse(Node node)
    {
        if (node != null)
        {
            Traverse(node.left);
            if (last != null)
            {
                last.right = node;
                node.left = last;
            }
            else
            {
                head = node;
            }
            last = node;

            Traverse(node.right);
        }
    }
}