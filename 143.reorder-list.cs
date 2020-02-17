/*
 * @lc app=leetcode id=143 lang=csharp
 *
 * [143] Reorder List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public void ReorderList(ListNode head)
    {
        return Reorder(head);
    }
    public ListNode Reorder(ListNode head)
    {
        if (head == null || head.next == null) return head;
        head.next = Reorder(head.next);
        return head;
    }
}
// @lc code=end

