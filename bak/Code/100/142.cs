using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null || head.next == null) return null;
        var fast = head;
        var slow = head;
        var isC = false;
        while (fast != null && slow !=null)
        {
            slow = slow.next;
            if (fast.next == null) return null;
            fast = fast.next.next;
            if (fast == slow) { isC = true; break; } 
        }
        if (!isC)
            return null;
        fast = head;
        while (fast != slow)
        {
            fast = fast.next;
            slow = slow.next;
        }
        return slow;
    }
}