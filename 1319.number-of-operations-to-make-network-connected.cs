/*
 * @lc app=leetcode id=1319 lang=csharp
 *
 * [1319] Number of Operations to Make Network Connected
 */

// @lc code=start
public class Solution
{
    private int[] parent;
    public int MakeConnected(int n, int[][] connections)
    {
        var extraCable = 0;
        var cluster = 0;
        this.parent = new int[n];
        for (var i = 0; i < n; i++)
            this.parent[i] = i;
        foreach (var conn in connections)
        {
            var p1 = GetParent(conn[0]);
            var p2 = GetParent(conn[1]);
            if (p1 != p2) this.parent[p1] = p2;
            else extraCable++;
        }

        for (int i = 0; i < n; i++) if (this.parent[i] == i) cluster++;
        return (extraCable >= cluster - 1) ? cluster - 1 : -1;
    }

    public int GetParent(int i)
    {
        if (this.parent[i] != i)
            this.parent[i] = GetParent(this.parent[i]);
        return this.parent[i];
    }
}
// @lc code=end

