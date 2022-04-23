public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {

        var d1 = cost[1];
        var d2 = cost[0];
        var res = 0;
        for (var i = 2; i <= cost.Length; i++)
        {
            res = (i == cost.Length ? 0 : cost[i]) + Math.Min(d1, d2);
            d2 = d1;
            d1 = res;
        }
        return res;
    }
}

