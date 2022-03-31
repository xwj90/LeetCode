public class Solution
{
    public int[][] ReconstructQueue(int[][] people)
    {
        var groups = new Dictionary<int, List<int>>();
        foreach (var item in people)
        {
            var h = item[0];
            if (!groups.ContainsKey(h)) groups[h] = new List<int>();
            groups[h].Add(item[1]);
        }

        var res = new List<int[]>();
        foreach (var pair in groups.OrderByDescending(p => p.Key))
        {
            foreach (var prev in pair.Value.OrderBy(p => p))
            {
                res.Insert(prev, new int[] { pair.Key, prev });
            }
        }
        return res.ToArray();
    }
}
// @lc code=end

