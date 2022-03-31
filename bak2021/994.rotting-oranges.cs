public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        var freshCount = 0;
        var previousFreshCount = 0;
        var rotten = new List<(int x, int y)>();
        for (var i = 0; i < grid.Length; i++)
            for (var j = 0; j < grid[i].Length; j++)
                if (grid[i][j] == 1) freshCount++;
                else if (grid[i][j] == 2) rotten.Add((i, j));

        var res = 0;
        do
        {
            previousFreshCount = freshCount;
            var newList = new List<(int x, int y)>();
            foreach (var point in rotten)
            {
                if (point.x > 0 && grid[point.x - 1][point.y] == 1)
                {
                    grid[point.x - 1][point.y] = 2;
                    newList.Add((point.x - 1, point.y));
                    freshCount--;
                }
                if (point.x < grid.Length - 1 && grid[point.x + 1][point.y] == 1)
                {
                    grid[point.x + 1][point.y] = 2;
                    newList.Add((point.x + 1, point.y));
                    freshCount--;
                }
                if (point.y > 0 && grid[point.x][point.y - 1] == 1)
                {
                    grid[point.x][point.y - 1] = 2;
                    newList.Add((point.x, point.y - 1));
                    freshCount--;
                }
                if (point.y < grid[0].Length - 1 && grid[point.x][point.y + 1] == 1)
                {
                    grid[point.x][point.y + 1] = 2;
                    newList.Add((point.x, point.y + 1));
                    freshCount--;
                }
            }
            if (previousFreshCount != freshCount) res++;
            rotten = newList;
        }
        while (freshCount != previousFreshCount);

        if (freshCount != 0) return -1;
        return res;

    }
}
// @lc code=end

