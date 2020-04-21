public class Solution
{
    public int[][] KClosest(int[][] points, int K)
    {

        var res = new SortedSet<(double dis, int id)>();
        for (var i = 0; i < points.Length; i++)
        {
            res.Add((Math.Sqrt(points[i][0] * points[i][0] + points[i][1] * points[i][1]), i));
            if (res.Count > K)
                res.Remove(res.Max);
        }

        var ans = new List<int[]>();
        foreach (var (dis, id) in res)
        {
            ans.Add(points[id]);
        }
        return ans.ToArray();
    }
}
// @lc code=end

