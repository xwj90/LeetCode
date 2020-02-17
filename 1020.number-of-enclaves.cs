public class Solution
{
    public int NumEnclaves(int[][] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A[i].Length; j++)
            {
                if (i == 0 || j == 0 || i == A.Length - 1 || j == A[i].Length - 1)
                    dfs(A, i, j);
            }
        }

        return A.Sum(p => p.Count(q => q == 1));
    }

    public void dfs(int[][] A, int i, int j)
    {
        if (i >= 0 && i < A.Length && j >= 0 && j < A[i].Length && A[i][j] == 1)
        {
            A[i][j] = 0;
            dfs(A, i, j + 1);
            dfs(A, i, j - 1);
            dfs(A, i + 1, j);
            dfs(A, i - 1, j);
        }
    }

}
// @lc code=end

