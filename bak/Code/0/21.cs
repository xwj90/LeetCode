using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        var left = l1;
        var right = l2;
        var start = new ListNode(int.MinValue);

        var current = start;
        while (left != null && right != null)
        {
            if (left.val > right.val)
            {
                current.next = right;
                current = right;
                right = right.next;
            }
            else
            {
                current.next = left;
                current = left;
                left = left.next;
            }
        }
        if (left != null)
            current.next = left;
        else
            current.next = right;
        return start.next;
    }
}





