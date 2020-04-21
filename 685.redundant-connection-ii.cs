public class Solution
{
    int[] parents;
    public int[] FindRedundantDirectedConnection(int[][] edges)
    {
        var candidate1 = new int[] { -1, -1 };
        var candidate2 = new int[] { -1, -1 };

        parents = new int[edges.Length + 1];
        foreach (var edge in edges)
        {
            if (parents[edge[1]] == 0)
                parents[edge[1]] = edge[0];
            else
            {
                candidate1 = new int[] { parents[edge[1]], edge[1] };
                candidate2 = new int[] { edge[0], edge[1] };
                edge[1] = 0;
            }
        }

        for (var i = 0; i < edges.Length; i++)
        {
            parents[i] = i;
        }

        for (var i = 0; i < edges.Length; i++)
        {
            if (edges[i][1] == 0) continue;

            var child = edges[i][1];
            var father = edges[i][0];

            if (GetParent(father) == child)
            {
                if (candidate1[0] == -1)
                    return edges[i]; // if there is no node which has 2 parents, means circle.
                return candidate1;
            }
            parents[child] = father;
        }
        return candidate2;
    }

    public int GetParent(int node)
    {
        if (parents[node] != node)
            parents[node] = GetParent(parents[node]);
        return parents[node];
    }
}
// @lc code=end

