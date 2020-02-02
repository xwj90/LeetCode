public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var result = new List<int>();
        if (matrix.Length == 0)
            return result;
        var maxX = matrix.Length;
        var maxY = matrix[0].Length;
        var minX = 1;
        var minY = 0;
        var totalCount = maxX * maxY;
        var x = 0;
        var y = 0;
        var direction = 1;


        for (var i = 0; i < totalCount; i++)
        {
            result.Add(matrix[x][y]);
            GetNextPosition(ref x, ref y, ref direction, ref minX, ref minY, ref maxX, ref maxY);
        }
        return result;
    }
    public void GetNextPosition(ref int x, ref int y, ref int direction, ref int minX, ref int minY, ref int maxX, ref int maxY)
    {
        if (direction == 1 && y == maxY - 1)
        {
            maxY--;
            direction = 2; //right to down
        }
        if (direction == 2 && x == maxX - 1)
        {
            direction = 3; //down to left
            maxX--;
        }
        if (direction == 3 && y == minY)
        {
            minY++;
            direction = 4; //left to up
        }
        if (direction == 4 && x == minX)
        {
            minX++;
            direction = 1; //up to right
        }

        if (direction == 1) y++;
        if (direction == 2) x++;
        if (direction == 3) y--;
        if (direction == 4) x--;
    }
}
// @lc code=end

