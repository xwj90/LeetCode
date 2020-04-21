public class Solution // too complex, hard to understand
{
    public void ReorderList(ListNode head)
    {
        if (head == null || head.next == null) return;

        //Find the middle of the list
        var p1 = head;
        var p2 = head;
        while (p2.next != null && p2.next.next != null) //pay attention to p2.next
        {
            p1 = p1.next;
            p2 = p2.next.next;
        }

        //Reverse the half after middle  1->2->3->4->5->6 to 1->2->3->6->5->4
        var preMiddle = p1;
        var preCurrent = p1.next;
        while (preCurrent.next != null)
        {
            var current = preCurrent.next;
            preCurrent.next = current.next;
            current.next = preMiddle.next;
            preMiddle.next = current;
        }

        //Start reorder one by one  1->2->3->6->5->4 to 1->6->2->5->3->4
        p1 = head;
        p2 = preMiddle.next;
        while (p1 != preMiddle)
        {
            preMiddle.next = p2.next;
            p2.next = p1.next;
            p1.next = p2;
            p1 = p2.next;
            p2 = preMiddle.next;
        }
    }

}
// @lc code=end

