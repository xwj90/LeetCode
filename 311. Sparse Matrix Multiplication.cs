public class Solution
{
    public int[][] Multiply(int[][] A, int[][] B)
    {
        var zeroRow = A.Select(p => p.Sum()).ToArray();
        var zeroColumn = new int[B[0].Length];
        for (var i = 0; i < B.Length; i++)
            for (var j = 0; j < B[i].Length; j++)
                zeroColumn[j] += B[i][j];

        var result = new int[A.Length][];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = new int[B[0].Length];
            for (var j = 0; j < result[i].Length; j++)
            {
                if (zeroRow[i] == 0 || zeroColumn[j] == 0)
                {
                    result[i][j] = 0;
                }
                else
                {
                    for (var k = 0; k < B.Length; k++)
                    {
                        result[i][j] += A[i][k] * B[k][j];
                    }
                }
            }
        }
        return result;
    }
}