public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        var dict = new Dictionary<int, int>();
        var reference = new Dictionary<int, HashSet<int>>();
        foreach (var edge in edges)
        {
            if (!dict.ContainsKey(edge[0]))
            {
                dict[edge[0]] = 0;
                reference[edge[0]] = new HashSet<int>();
            }
            if (!dict.ContainsKey(edge[1]))
            {
                dict[edge[1]] = 0;
                reference[edge[1]] = new HashSet<int>();
            }
            dict[edge[0]]++;
            dict[edge[1]]++;
            reference[edge[0]].Add(edge[1]);
            reference[edge[1]].Add(edge[0]);
        }

        var res = new List<int>();
        for (var i = 0; i < n; i++) res.Add(i);

        while (dict.Any())
        {
            var min = dict.Min(p => p.Value);
            var minNodes = dict.Where(p => p.Value == min).ToList();
            res = minNodes.Select(p => p.Key).ToList();

            foreach (var node in minNodes)
                foreach (var targetId in reference[node.Key])
                {
                    dict[targetId]--;
                    reference[targetId].Remove(node.Key);
                }
            foreach (var node in minNodes)
                dict.Remove(node.Key);
        }

        return res;
    }
}
// @lc code=end

