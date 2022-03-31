using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    private ListNode Solution_ListNode_382;
    private Random Solution_random_382;
    public Solution(ListNode head)
    {
        this.Solution_ListNode_382 = head;
        this.Solution_random_382 = new Random();
    }

    /** Returns a random node's value. */
    public int GetRandom()
    {

        int c = 1;
        var v = 0;
        var node = Solution_ListNode_382;
        while (node != null)
        {
            if (this.Solution_random_382.Next(c++) == 0)
                v = node.val;
            node = node.next;
        }
        return v;
    }
}