public class Solution
{
    public IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        var map = new Dictionary<string, List<string>>();
        foreach (var item in tickets)
        {
            if (!map.ContainsKey(item[0]))
                map[item[0]] = new List<string>() { };
            map[item[0]].Add(item[1]);
        }

        foreach (var key in map.Keys)
        {
            map[key].Sort();
        }

        var res = new List<string>() { "JFK" };
        Search(map, res, tickets.Count + 1);
        return res;
    }

    public bool Search(Dictionary<string, List<string>> map, List<string> path, int target)
    {
        if (path.Count == target) return true;
        if (map.TryGetValue(path.Last(), out var val))
        {
            if (val.Any())
            {
                for (var i = 0; i < val.Count; i++)
                {
                    var next = val[i];
                    val.RemoveAt(i);
                    path.Add(next);

                    if (Search(map, path, target))
                        return true;

                    path.RemoveAt(path.Count - 1);
                    val.Insert(i, next);
                }
            }
        }
        return false;
    }
}
// @lc code=end

//[["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
//[["JFK","ATL"],["ATL","JFK"]]


//   var map = new Dictionary<string, List<string>>();
//         var outgoing = new Dictionary<string, int>();
//         foreach (var item in tickets)
//         {
//             if (!map.ContainsKey(item[0]))
//                 map[item[0]] = new List<string>() { };
//             if (!outgoing.ContainsKey(item[0]))
//                 outgoing[item[0]] = 0;
//             if (!outgoing.ContainsKey(item[1]))
//                 outgoing[item[1]] = 0;

//             map[item[0]].Add(item[1]);
//             outgoing[item[0]]++;
//             outgoing[item[1]]--;
//         }

//         string start = "JFK";
//         foreach (var key in map.Keys)
//         {
//             map[key] = map[key].OrderBy(x => x).ToList();
//         }

//         var res = new List<string>() { start };
//         while (map.Any())
//         {
//             var list = map[start];
//             var next = list.First();
//             list.Remove(next);

//             if (!list.Any())
//                 map.Remove(start);

//             start = next;
//             res.Add(next);
//         }
//         return res;