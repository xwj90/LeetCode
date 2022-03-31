public class Solution
{
    public IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        // var map = new Dictionary<string, List<string>>();
        // var incomingCount = new Dictionary<string, int>();
        // var stops = new HashSet<string>();
        // foreach (var ticket in tickets)
        // {
        //     if (!map.ContainsKey(ticket[0]))
        //         map[ticket[0]] = new List<string>();
        //     map[ticket[0]].Add(ticket[1]);

        //     if (!incomingCount.ContainsKey(ticket[1]))
        //         incomingCount[ticket[1]] = 0;
        //     incomingCount[ticket[1]]++;

        //     stops.Add(ticket[0]);
        //     stops.Add(ticket[1]);

        // }

        // var res = new List<string>();
        // while (stops.Any())
        // {
        //     var keys = stops.Where(p => !incomingCount.ContainsKey(p)).ToArray();;
        //     res.AddRange(keys.OrderBy(p => p));
        //     foreach (var key in keys)
        //     {
        //         if (map.ContainsKey(key))
        //         {
        //             foreach (var target in map[key])
        //             {
        //                 if (--incomingCount[target] == 0)
        //                 {
        //                     incomingCount.Remove(target);
        //                 }
        //             }
        //         } 
        //         stops.Remove(key);
        //     }
        // }

        // return res;
    }
}
// @lc code=end

