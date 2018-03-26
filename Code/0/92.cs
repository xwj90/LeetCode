using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public ListNode ReverseBetween(ListNode head, int m, int n)
    {
        var fake = new ListNode(int.MinValue);
        fake.next = head;
        var pre = fake;
        for (int i = 0; i < m - 1; i++)
            pre = pre.next;
        var start = pre.next;
        var end = start.next;
        for (int i = 0; i < n - m; i++)
        {
            start.next = end.next;
            end.next = pre.next;
            pre.next = end;
            end = start.next;// move to next
        }
        return fake.next;
    }
}