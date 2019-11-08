using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode InsertionSortList(ListNode head)
    {
        var fakeHead = new ListNode(int.MinValue);
        fakeHead.next = head;
        var current = head;

        var end = head;
        while (current != null)
        {
            var before = fakeHead;
            var next = current.next;
            while (before.next != null && before.next != current && before.next.val < current.val)
                before = before.next;

            if (before.next != current)
            {
                current.next = before.next;
                before.next = current;
                end.next = next;
            }
            else
            {
                end = current;
            }

            current = next;//move to next element

        }
        return fakeHead.next;

    }
}