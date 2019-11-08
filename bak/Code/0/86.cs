using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode Partition(ListNode head, int x)
    {
        ListNode small = null;
        ListNode lastSmall = null;
        ListNode large = null;
        ListNode lastLarge = null;
        var current = head;
        while (current != null)
        {
            if (current.val < x)
            {
                if (small == null)
                {
                    small = current;
                    lastSmall = current;
                }
                else
                {
                    lastSmall.next = current;
                    lastSmall = current;
                }
            }
            else
            {
                if (large == null)
                {
                    large = current;
                    lastLarge = current;
                }
                else
                {
                    lastLarge.next = current;
                    lastLarge = current;
                }
            }
            current = current.next;
        }
        if (lastSmall != null)
            lastSmall.next = large;
        if (lastLarge != null)
            lastLarge.next = null;
        if (small == null)
            return large;
        else
            return small;
    }
}
