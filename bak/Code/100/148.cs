using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null) return head;
        var slow = head;
        var fast = head;
        var prev = head;
        while(fast!=null && fast.next!=null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        prev.next = null;

        var left = SortList(head);
        var right = SortList(slow);
        return SortList_Merge(left, right);

    }

    private ListNode SortList_Merge(ListNode left, ListNode right)
    {
        var fake = new ListNode(0);
        var current = fake;
        while(left!=null && right!=null)
        {
            if (left.val >= right.val)
            {
                current.next = right;
                right = right.next;
            }
            else
            {
                current.next = left;
                left = left.next;
            }
            current = current.next;
        }
        if (left != null) current.next = left;
        else if (right != null) current.next = right;
        return fake.next;
    }
}