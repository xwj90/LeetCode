using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        ListNode current = head;
        int count = 0;
        while (current != null && count != k)
        {
            current = current.next;
            count++;
        }
        if (count == k)
        {
            current = ReverseKGroup(current, k);
            while (count-- > 0)
            {
                var temp = head.next;
                head.next = current;
                current = head;
                head = temp;
            }
            head = current;
        }
        return head;

    }

}





