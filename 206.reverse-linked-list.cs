public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        var current = head;

        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}
// @lc code=end

