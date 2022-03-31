
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public TreeNode SortedListToBST(ListNode head)
    {
        if (head == null) return null;
        return SortedListToBST_Build(head, null);
    }
    TreeNode SortedListToBST_Build(ListNode head, ListNode tail)
    {
        if (head == tail)
            return null;
        ListNode fast = head;
        ListNode slow = head;
        while (fast != tail && fast.next != tail)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        var node = new TreeNode(slow.val);
        node.left = SortedListToBST_Build(head, slow);
        node.right = SortedListToBST_Build(slow.next, tail);
        return node;
    }

}