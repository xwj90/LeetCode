public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var profit = new int[gas.Length];
        for (var i = 0; i < gas.Length; i++)
            profit[i] = gas[i] - cost[i];
        if (profit.Sum() < 0)
            return -1;
        var sum = 0;
        int? start = 0;
        for (var i = 0; i < profit.Length; i++)
        {
            sum += profit[i];

            if (!start.HasValue && sum >= 0)
                start = i;
            if (sum < 0)
            {
                sum = 0;
                start = null;
            }
        }
        return start.Value;
    }
}
