using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;
        List<ListNode> list = lists.ToList();
        while (list.Count > 1)
        {
            list.Add(MergeKLists_MergeTwo(list[0], list[1]));
            list.RemoveAt(0);
            list.RemoveAt(0);
        }
        return list[0];
    }
    private ListNode MergeKLists_MergeTwo(ListNode n1, ListNode n2)
    {
        if (n1 == null)
            return n2;
        else if (n2 == null)
            return n1;
        if (n1.val > n2.val)
        {
            n2.next = MergeKLists_MergeTwo(n1, n2.next);
            return n2;
        }
        else
        {
            n1.next = MergeKLists_MergeTwo(n1.next, n2);
            return n1;
        }
    }

}





