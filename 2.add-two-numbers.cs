public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        var root = new ListNode(0);
        var current = root;
        var previousNumber = 0;

        while (l1 != null || l2 != null)
        {
            var currentValue = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + previousNumber;
            previousNumber = currentValue / 10;
            current.next = new ListNode(currentValue % 10);
            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        if (previousNumber > 0)
        {
            current.next = new ListNode(previousNumber);
        }

        return root.next;
    }
}
// @lc code=end

