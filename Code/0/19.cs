using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var node = Reverse(head);
        var next = node.next;
        if (n == 1)
            return Reverse(next);
        var current = node;
        var i = 1;
        while (i < n - 1)
        {
            next = next.next;
            current = current.next;
            i++;
        }
        current.next = next.next;
        return Reverse(node);

    }
    ListNode Reverse(ListNode node)
    {
        ListNode current = null;
        ListNode next = node;
        while (next != null)
        {
            var temp = next.next;
            next.next = current;
            current = next;
            next = temp;
        }
        return current;
    }
}





