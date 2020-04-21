public class Solution
{
    public string AlienOrder(string[] words)
    {
        var order = new HashSet<(char source, char targer)>();
        var groups = new Queue<IEnumerable<string>>();
        var chars = new HashSet<char>();
        groups.Enqueue(words);
        while (groups.Any())
        {
            var group = groups.Dequeue().ToList();
            if (group.Count() >= 2 && group.First().Length > 0 && group.Skip(1).Any(p => p.Length == 0)) return string.Empty;
            group = group.Where(p => p.Length > 0).ToList();

            for (var i = 0; i < group.Count; i++)
            {
                chars.Add(group[i][0]);
                for (var j = i + 1; j < group.Count; j++)
                {
                    if (group[i][0] != group[j][0])
                        order.Add((group[i][0], group[j][0]));
                }
            }

            foreach (var newGroup in group.GroupBy(p => p[0]))
            {
                var temp = newGroup.Select(p => p.Substring(1));
                groups.Enqueue(temp);
            }
        }


        var dict = new Dictionary<char, int>();
        var conn = new Dictionary<char, List<char>>();
        foreach (var (s, t) in order)
        {
            if (!conn.ContainsKey(s)) conn[s] = new List<char>();
            conn[s].Add(t);

            if (!dict.ContainsKey(t)) dict[t] = 0;
            if (!dict.ContainsKey(s)) dict[s] = 0;
            dict[t]++;
        }

        Console.WriteLine(string.Join(",", dict.Select(p => $"{p.Key}:{p.Value}")));
        var res = new List<char>();
        char[] keys;
        do
        {
            keys = dict.Where(p => p.Value == 0).Select(p => p.Key).ToArray();
            res.AddRange(keys);
            foreach (var key in keys)
                if (conn.ContainsKey(key))
                    foreach (var c in conn[key])
                        dict[c]--;
            foreach (var key in keys)
                dict.Remove(key);
        }
        while (keys.Any());

        foreach (var c in chars)
            if (!res.Contains(c))
                res.Add(c);

        if (dict.Any()) return string.Empty;
        return new string(res.ToArray());
    }
}