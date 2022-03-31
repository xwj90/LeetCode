public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var sortedSet = new SortedSet<(long idx, ListNode node)>(Comparer<(long idx, ListNode node)>.Create((s1, s2) => s1.idx.CompareTo(s2.idx)));
        long count = 0;
        foreach (var node in lists.Where(p => p != null))
            sortedSet.Add(((long)node.val * int.MaxValue + count++, node));

        var head = new ListNode(-1);
        var current = head;
        while (sortedSet.Any())
        {
            var min = sortedSet.Min; //remove the minimum element
            current.next = min.node;
            current = current.next;
            sortedSet.Remove(min);
            if (current.next != null)
                sortedSet.Add(((long)current.next.val * int.MaxValue + count++, current.next));

        }
        return head.next;
    }
}