/*
 * @lc app=leetcode id=109 lang=csharp
 *
 * [109] Convert Sorted List to Binary Search Tree
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    List<int> values = new List<int>();
    public TreeNode SortedListToBST(ListNode head)
    {
        while (head != null)
        {
            this.values.Add(head.val);
            head = head.next;
        }
        return convert(0, this.values.Count - 1);
    }
    public TreeNode convert(int left, int right)
    {
        if (left > right) return null;
        var mid = (left + right) / 2;
        var node = new TreeNode() { val = this.values[mid] };
        node.left = convert(left, mid - 1);
        node.right = convert(mid + 1, right);
        return node;
    }
}

