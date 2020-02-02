public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix.Length == 0)
            return false;
        if (matrix[0].Length == 0)
            return false;
        var m = matrix.Length;
        var n = matrix[0].Length;
        var left = 0;
        var right = m * n - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (matrix[mid / n][mid % n] == target)
                return true;
            else if (matrix[mid / n][mid % n] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
}
// @lc code=end

