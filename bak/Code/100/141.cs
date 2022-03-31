using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null) return false;
        var fast = head.next;
        var slow = head;
        while(fast!=null)
        {
            if (fast == slow) return true;
            if (fast.next == null) return false;
            fast = fast.next.next;
            slow = slow.next;
        }
        return false;
    }
}