public class Solution
{
    public int LongestIncreasingPath(int[][] matrix)
    {
        if (matrix.Length == 0) return 0;

        var dict = new Dictionary<int, List<(int x, int y)>>();
        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (!dict.ContainsKey(matrix[i][j])) dict[matrix[i][j]] = new List<(int x, int j)>();
                dict[matrix[i][j]].Add((i, j));
            }
        }
        var output = new int[matrix.Length, matrix[0].Length];
        var max = 0;
        foreach (var pair in dict.OrderByDescending(p => p.Key))
        {
            foreach (var (x, y) in pair.Value)
            {
                output[x, y] = GetAroundValues(output, matrix, x, y);
                max = Math.Max(max, output[x, y]);
            }
        }
        return max;
    }
    private int GetAroundValues(int[,] output, int[][] matrix, int x, int y)
    {
        var v = matrix[x][y];
        var res = new List<int>();
        if (x > 0 && matrix[x - 1][y] > v) res.Add(output[x - 1, y]);
        if (y > 0 && matrix[x][y - 1] > v) res.Add(output[x, y - 1]);

        if (x < output.GetLength(0) - 1 && matrix[x + 1][y] > v) res.Add(output[x + 1, y]);
        if (y < output.GetLength(1) - 1 && matrix[x][y + 1] > v) res.Add(output[x, y + 1]);
        if (res.Any())
        {
            return res.Max() + 1;
        }
        else
        {
            return 1;
        }
    }
}
// @lc code=end

