using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 369. Plus One Linked List
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode PlusOne(ListNode head)
    {
        ListNode last = null;
        ListNode temp;
        var current = head;
        while(current!=null)
        {
            if (current.val != 9)
                last = current;
            if(current.next==null)
            {
               if(current.val==9)
                {
                    if (last == null)
                    {
                        temp = new ListNode(1);
                        temp.next = head;
                        head = temp;
                    }
                    else
                    {
                        temp = last;
                        temp.val++;
                    }
                    while(temp.next!=null)
                    {
                        temp.next.val = 0;
                        temp = temp.next;
                    }
                }
               else
                {
                    current.val++;
                    return head;
                }
            }
            current = current.next;
        }
        return head;
    }
}