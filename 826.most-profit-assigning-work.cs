public class Solution
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        var list = new List<(int difficulty, int profit)>();
        for (var i = 0; i < difficulty.Length; i++)
        {
            list.Add((difficulty[i], profit[i]));
        }
        list = list.OrderBy(p => p.difficulty).ToList();

        var max = int.MinValue;
        for (var i = 0; i < list.Count; i++)
        {
            max = Math.Max(list[i].profit, max);
            list[i] = (list[i].difficulty, max);
        }
        var res = 0;
        foreach (var w in worker)
        {
            var v = list.BinarySearch((w, int.MaxValue));

            if (v < 0) v = ~v - 1;
            if (v > list.Count - 1) v = list.Count - 1;
            if (v < list.Count && v >= 0) res += list[v].profit;
        }
        return res;
    }
}
// @lc code=end

