
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> hs = new HashSet<ListNode>();
        var n = headA;
        while (n != null)
        {
            hs.Add(n);
            n = n.next;
        }
        n = headB;
        while (n != null)
        {
            if (hs.Contains(n))
                return n;
            n = n.next;
        }
        return null;
    }


}