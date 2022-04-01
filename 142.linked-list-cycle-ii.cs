public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        var slow = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                while (fast != head)
                {
                    fast = fast.next;
                    head = head.next;
                }
                return fast;
            }
        }
        return null;
    }
}
// @lc code=end

