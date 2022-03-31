/*
 * @lc app=leetcode id=117 lang=csharp
 *
 * [117] Populating Next Right Pointers in Each Node II
 */
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node(){}
    public Node(int _val,Node _left,Node _right,Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
}
*/
public class Solution
{
    Dictionary<int, List<Node>> dict = new Dictionary<int, List<Node>>();
    public Node Connect(Node root)
    {
        Travrse(root, 0);
        return root;
    }
    public void Travrse(Node root, int level)
    {
        if (root == null)
            return;

        if (!dict.ContainsKey(level))
        {
            dict[level] = new List<Node>();
        }
        else
        {
            root.next = dict[level][dict[level].Count - 1];
        }
        dict[level].Add(root);

        Travrse(root.right, level + 1);
        Travrse(root.left, level + 1);
    }
}

