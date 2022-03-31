/*
 * @lc app=leetcode id=240 lang=csharp
 *
 * [240] Search a 2D Matrix II
 */

// @lc code=start
public class Solution
{
    public bool SearchMatrix(int[,] matrix, int target)
    {
        var x = matrix.GetLength(0) - 1;
        var y = 0;
        while (x >= 0 && y < matrix.GetLength(1))
        {
            if (matrix[x, y] > target) x--;
            else if (matrix[x, y] < target) y++;
            else return true;
        }
        return false;
    }
}
// @lc code=end

