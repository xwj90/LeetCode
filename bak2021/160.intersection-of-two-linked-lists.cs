/*
 * @lc app=leetcode id=160 lang=csharp
 *
 * [160] Intersection of Two Linked Lists
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
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var hs = new HashSet<ListNode>();
        while (headA != null)
        {
            hs.Add(headA);
            headA = headA.next;
        }

        while (headB != null)
        {
            if (hs.Contains(headB)) return headB;
            headB = headB.next;
        }
        return null;
    }
}
// @lc code=end

