public class Solution
{
    public bool IsBipartite(int[][] graph)
    {
        var status = new int[graph.Length];
        for (var i = 0; i < graph.Length; i++)
        {
            if (status[i] == 0)
            {
                var res = DFS(graph, i, status);
                if (!res) return false;
            }
        }
        return true;
    }
    private bool DFS(int[][] graph, int i, int[] status, int group = 1)
    {
        if (status[i] != 0)
            return status[i] == group;
        status[i] = group;

        foreach (var target in graph[i])
        {
            var res = DFS(graph, target, status, -group);
            if (!res) return false;
        }
        return true;
    }
}