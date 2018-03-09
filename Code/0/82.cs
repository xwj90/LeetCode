using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var fake = new ListNode(int.MinValue);
        fake.next = head;
        var current = fake;
        var v = int.MinValue;
        while (current.next != null && current.next.next != null)
        {
            if (current.next.val == current.next.next.val)
            {
                v = current.next.val;
                while (current.next != null && current.next.val == v)
                    current.next = current.next.next;
            }
            else
                current = current.next;
        }
        return fake.next;
    }
}
