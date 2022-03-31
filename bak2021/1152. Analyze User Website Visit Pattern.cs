public class Solution
{
    public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
    {
        var logs = new (int timestamp, string username, string website)[username.Length];
        for (var i = 0; i < username.Length; i++)
            logs[i] = (timestamp[i], username[i], website[i]);

        Array.Sort(logs);
        var result = new Dictionary<(string w1, string w2, string w3), HashSet<string>>();
        foreach (var userLogs in logs.GroupBy(p => p.username).Select(p => p.ToList()))
        {
            for (var i = 0; i < userLogs.Count; i++)
            {
                for (var j = i + 1; j < userLogs.Count; j++)
                {
                    for (var k = j + 1; k < userLogs.Count; k++)
                    {
                        var key = (userLogs[i].website, userLogs[j].website, userLogs[k].website);
                        if (!result.ContainsKey(key))
                            result[key] = new HashSet<string>();
                        result[key].Add(userLogs[i].username);
                    }
                }
            }
        }

        var res = result.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key).First();
        return new string[] { res.Key.w1, res.Key.w2, res.Key.w3 };
    }
}