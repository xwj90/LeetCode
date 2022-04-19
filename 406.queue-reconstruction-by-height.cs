public class Solution
{
    public int[][] ReconstructQueue(int[][] people)
    {
        var queue = new (int h, int k)[people.Length];
        for (var i = 0; i < people.Length; i++)
        {
            queue[i] = (-people[i][0], people[i][1]);
        }
        Array.Sort(queue);
        var result = new List<int[]>();
        for (var j = 0; j < queue.Length; j++)
        {
            var (h, k) = queue[j];
            h = -h;
            var count = 0;
            var insert = false;

            if (k <= result.Count)
                result.Insert(k, new int[] { h, k });
            else
                result.Add(new int[] { h, k });

        }
        return result.ToArray();
    }
}
// @lc code=end

