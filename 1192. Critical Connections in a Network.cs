public class Solution
{
    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
    {
        var map = connections
        .Union(connections.Select(p => new List<int>() { p[1], p[0] }))
        .GroupBy(p => p[0])
        .ToDictionary(p => p.Key, p => p.Select(q => q[1]).ToList());

        var visited = Enumerable.Repeat(-1, n).ToArray();
        var result = new List<IList<int>>();
        var rank = new int[n];
        for (var i = 0; i < n; i++)
        {
            if (visited[i] == -1)
            {
                DFS(i, rank, visited, map, result, i);
            }
        }
        return result;
    }

    private int time = 0;

    private void DFS(int u, int[] rank, int[] visited, Dictionary<int, List<int>> dict, List<IList<int>> result, int pre)
    {
        visited[u] = rank[u] = ++time; // discovered u;
        foreach(var v in dict[u]) //iterate all of the nodes connected to u
        {
            if (v == pre)  continue;   //if parent vertex ignore
            if (visited[v] == -1) // if not visited
            {
                DFS(v, rank, visited, dict, result, u);
                rank[u] = Math.Min(rank[u], rank[v]);
                if (rank[v] > visited[u])
                {
                    //u-v is critical there is no path for v to reach back to u or previous vertices of u
                    result.Add(new List<int> { u, v });
                }
            }
            else // if v is already visited put the minimum into low for vertex u
            {
                rank[u] = Math.Min(rank[u], visited[v]);
            }
        }
    }
}