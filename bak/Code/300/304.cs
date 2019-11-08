using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NumMatrix
{
	private int[,] dp;
	public NumMatrix(int[,] matrix)
	{
		dp = new int[matrix.GetLength(0) + 1, matrix.GetLength(1) + 1];
		for (int i = 1; i <= matrix.GetLength(0); i++)
			for (int j = 1; j <= matrix.GetLength(1); j++)
				dp[i,j] = dp[i - 1,j] + dp[i,j - 1] - dp[i - 1,j - 1] + matrix[i - 1,j - 1];
	}

	public int SumRegion(int row1, int col1, int row2, int col2)
	{
		int iMin = Math.Min(row1, row2);
		int iMax = Math.Max(row1, row2);

		int jMin = Math.Min(col1, col2);
		int jMax = Math.Max(col1, col2);

		return dp[iMax + 1,jMax + 1] - dp[iMax + 1,jMin] - dp[iMin,jMax + 1] + dp[iMin,jMin];
	}
}
