using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        var n = head.next;
        head.next = SwapPairs(n.next);
        n.next = head;
        return n;
    }
}





