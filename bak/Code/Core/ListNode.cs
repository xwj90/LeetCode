using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }

    public static ListNode Create(int[] a)
    {
        ListNode start = new ListNode(a[0]);
        var current = start;
        for (int i = 1; i < a.Length; i++)
        {
            current.next = new ListNode(a[i]);
            current = current.next;
        }
        return start;
    }
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        var current = this;
        while (current != null)
        {
            sb.Append(current.val + ">");
            current = current.next;
        }
        return sb.ToString().Trim('>');
    }
    public override bool Equals(object obj)
    {
        var left = this;
        var right = (ListNode)obj;

        return left.ToString() == right.ToString();
    }
    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }
}
public static class ListNodeHelper
{
    public static int[]  ToArray(this ListNode node)
    {
        List<int> r = new List<int>();
        var c = node;
        while(c!=null)
        {
            r.Add(c.val);
            c = c.next;
        }
        return r.ToArray();
    }
}
