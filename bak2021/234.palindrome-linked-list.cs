public class Solution // i don't understand
{
    public bool IsPalindrome(ListNode head)
    {
        var fast = head;
        var slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        if (fast != null)
            slow = slow.next;

        slow = Reverse(slow);
        fast = head;

        while (slow != null)
        {
            if (fast.val != slow.val) return false;
            fast = fast.next;
            slow = slow.next;
        }
        return true;
    }
    public ListNode Reverse(ListNode head)
    {
        ListNode prev = null;
        while (head != null)
        {
            var next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }
}
// @lc code=end

