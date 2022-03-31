public class Solution
{
    public int MinRefuelStops(int target, int startFuel, int[][] stations)
    {
        if (stations.Length == 0) return 0;

        var cost = new List<int>();
        var currentCapacity = startFuel;
        var sum = 0;
        var stops = 0;
        var sort = new SortedSet<(int fuel, int idx)>();
        var res = 0;
        for (var i = 0; i < stations.Length; i++)
        {
            sum += cost[i];
            cost.Add(sum);
        }

        while (currentCapacity < cost.Last())
        {
            var i = cost.BinarySearch(currentCapacity);
            if (i < 0) i = ~i - 1;
            for (stops = stops; stops <= i; stops++)
            {
                sort.Add((stations[stops][0], stops));
            }
            if (sort.Any())
            {
                var max = sort.Max;
                currentCapacity += max.fuel;
                res++;
                sort.Remove(max);
            }
            else
            {
                return -1;
            }
        }
        return res;

    }
}
// @lc code=end

