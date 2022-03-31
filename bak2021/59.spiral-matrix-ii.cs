public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        var array = new int[n][];
        for (var i = 0; i < n; i++)
            array[i] = new int[n];

        var minX = 1;
        var minY = 0;
        var maxX = n;
        var maxY = n;

        var x = 0;
        var y = 0;
        var direction = 1;
        for (var i = 1; i <= n * n; i++)
        {
            array[x][y] = i;

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
        return array;
    }
}
// @lc code=end

