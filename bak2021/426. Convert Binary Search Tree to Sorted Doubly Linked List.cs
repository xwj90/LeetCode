public class Solution
{
    public Node TreeToDoublyList(Node root)
    {
        if (root == null) return null;
        var s = new Stack<Node>();
        Node head = null;
        Node last = null;
        Node current = root;

        while (current != null || s.Any())
        {
            while (current != null)
            {
                s.Push(current);
                current = current.left;
            }
            current = s.Pop();
            if (head == null)
                head = current;
            if (last != null)
            {
                current.left = last;
                last.right = current;
            }
            last = current;
            current = current.right;
        }
        head.left = last;
        last.right = head;
        return head;
    }
}