public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        var left = matrix[0][0];
        var right = matrix[matrix.Length - 1][matrix[0].Length - 1] + 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            int count = 0;
            int j = matrix[0].Length - 1;
            for (var i = 0; i < matrix.Length; i++)
            {
                while (j >= 0 && matrix[i][j] > mid) j--;
                count += (j + 1);
            }
            if (count < k) left = mid + 1;
            else right = mid;
        }

        return left;
    }
}
// @lc code=end

