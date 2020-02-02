/*
 * @lc app=leetcode id=85 lang=csharp
 *
 * [85] Maximal Rectangle
 */

// @lc code=start
public class Solution
{

    public int MaximalRectangle(char[][] matrix)
    {

    }

    public (int, int) MaximalRectangle(char[][] matrix, int x, int y, Dictionary<(int, int), (int, int)> cache)
    {
        if (x < 0 || y < 0) return 0;
        if (matrix[x][y] == '0')
            return 0;
        if (cache.ContainsKey((x, y))) return cache[(x, y)];
        var left = MaximalRectangle(x - 1, y);

        var height = 0;
        for (var i = y; i >= 0 && matrix[x][i] == '1'; i--)
            height++;

        var top = MaximalRectangle(x, y - 1);
    }
}
// @lc code=end

