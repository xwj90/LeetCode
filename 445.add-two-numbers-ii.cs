public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var s1 = new Stack<int>();
        var s2 = new Stack<int>();
        while (l1 != null)
        {
            s1.Push(l1.val);
            l1 = l1.next;
        }
        while (l2 != null)
        {
            s2.Push(l2.val);
            l2 = l2.next;
        }

        var sum = 0;
        var node = new ListNode(0);
        while (s1.Any() || s2.Any())
        {
            if (s1.Any()) sum += s1.Pop();
            if (s2.Any()) sum += s2.Pop();
            node.val = sum % 10;
            var head = new ListNode(sum / 10);
            head.next = node;
            node = head;
            sum /= 10;
        }
        return node.val == 0 ? node.next : node;
    }

}
// @lc code=end

