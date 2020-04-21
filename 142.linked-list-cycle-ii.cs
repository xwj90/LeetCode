/*
 * @lc app=leetcode id=142 lang=csharp
 *
 * [142] Linked List Cycle II
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null) return null;

        ListNode res = null;
        var slow = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                res = fast;
                break;
            }
        }

        if (res == null) return null; //no loop

        slow = head;
        fast = res;
        while (slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }
        return slow;


    }
}
// @lc code=end

