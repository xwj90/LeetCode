public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        var second = head.next;
        head.next = SwapPairs(head.next.next);
        second.next = head;
        return second;
    }
}
// @lc code=end

