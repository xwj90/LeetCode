public class Solution
{
    Dictionary<int, int> parents = new Dictionary<int, int>();
    public int NumComponents(ListNode head, int[] G)
    {
        var keys = new HashSet<int>();
        foreach (var g in G)
        {
            parents[g] = g;
            keys.Add(g);
        }
        var current = head;
        while (current != null)
        {
            if (current.next != null && keys.Contains(current.val) && keys.Contains(current.next.val)) Connect(current.val, current.next.val);
            current = current.next;
        }
        var res = new HashSet<int>();
        foreach (var g in G)
            res.Add(GetTop(g));
        return res.Count;
    }
    private void Connect(int v1, int v2)
    {
        if (v1 > v2) Connect(v2, v1);
        else
        {
            var top1 = GetTop(v1);
            var top2 = GetTop(v2);
            if (top1 != top2) parents[top1] = top2;
        }

    }
    private int GetTop(int v)
    {
        if (!parents.ContainsKey(v))
        {
            parents[v] = v;
            return v;
        }
        else if (parents[v] == v)
        {
            return v;
        }
        else
        {
            return GetTop(parents[v]);
        }
    }
}
// @lc code=end

