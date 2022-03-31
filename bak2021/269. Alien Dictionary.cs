public class Solution
{
    public string AlienOrder(string[] words)
    {
        var order = new HashSet<(char source, char targer)>();
        var groups = new Queue<(List<string>, int)>();
        var chars = new HashSet<char>() { ' ' };

        foreach (var w in words)
            foreach (var c in w)
            {
                chars.Add(c);
                order.Add((' ', c));
            }

        groups.Enqueue((words.Select(p => p + " ").ToList(), 0));
        while (groups.Any())
        {
            var (group, start) = groups.Dequeue();
            group = group.Where(p => p.Length > start).ToList();
            if (group.Count >= 2)
            {
                for (var i = 1; i < group.Count; i++)
                    if (group[i - 1][start] != group[i][start])
                        order.Add((group[i - 1][start], group[i][start]));

                foreach (var newGroup in group.GroupBy(p => p[start]))
                    groups.Enqueue((newGroup.ToList(), start + 1));
            }
        }

        var dict = new Dictionary<char, int>();
        var conn = new Dictionary<char, List<char>>();

        foreach (var c in chars)
        {
            dict[c] = 0;
            conn[c] = new List<char>();
        }

        foreach (var (s, t) in order)
        {
            conn[s].Add(t);
            dict[t]++;
        }

        var q = new Queue<char>(dict.Where(p => p.Value == 0).Select(p => p.Key));
        var res = new List<char>();
        while (q.Any())
        {
            var c = q.Dequeue();
            if (dict.ContainsKey(c))
            {
                res.Add(c);
                dict.Remove(c);
                foreach (var t in conn[c])
                    if (--dict[t] == 0)
                        q.Enqueue(t);
            }
        }
        if (dict.Any()) return string.Empty;
        return new string(res.ToArray()).Trim();
    }
}