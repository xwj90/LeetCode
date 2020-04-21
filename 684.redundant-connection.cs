public class Solution
{
    int[] parents;
    public int[] FindRedundantConnection(int[][] edges)
    {
        parents = new int[1001];
        for (var i = 0; i < edges.Length; i++)
        {
            parents[edges[i][0]] = edges[i][0];
            parents[edges[i][1]] = edges[i][1];
        }
        for (var i = 0; i < edges.Length; i++)
        {
            if (Connect(edges[i][0], edges[i][1]))
            {
                return edges[i];
            }
        }
        return null;
    }

    public bool Connect(int node1, int node2)
    {
        var p1 = GetParent(node1);
        var p2 = GetParent(node2);
        if (p1 != p2)
        {
            parents[p1] = p2;
            return false;
        }
        return true;
    }

    public int GetParent(int node)
    {
        if (parents[node] != node)
            parents[node] = GetParent(parents[node]);
        return parents[node];
    }
}
// @lc code=end

