/*
 * @lc app=leetcode id=25 lang=csharp
 *
 * [25] Reverse Nodes in k-Group
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
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        ListNode current = head;
        int count = 0;
        while (current != null && count != k)
        {
            current = current.next;
            count++;
        }
        if (count == k)
        {
            current = ReverseKGroup(current, k);
            while (count-- > 0)
            {
                var temp = head.next;
                head.next = current;
                current = head;
                head = temp;
            }
            head = current;
        }
        return head;
    }
}
// @lc code=end

