public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        if (matrix.Length >= 1)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var rows = new int[m];
            var columns = new int[n];
            for (var i = 0; i < m; i++)
                for (var j = 0; j < n; j++)
                    if (matrix[i][j] == 0)
                    {
                        rows[i] = 1;
                        columns[j] = 1;
                    }

            for (var i = 0; i < m; i++)
                if (rows[i] == 1)
                    for (var j = 0; j < n; j++)
                        matrix[i][j] = 0;

            for (var j = 0; j < n; j++)
                if (columns[j] == 1)
                    for (var i = 0; i < m; i++)
                        matrix[i][j] = 0;
        }
    }
}
// @lc code=end

