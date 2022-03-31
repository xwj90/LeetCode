public class Solution
{
    List<(int x, int y)> directions = new List<(int, int)>() { (0, 1), (0, -1), (1, 0), (-1, 0) };
    Dictionary<(int, int, int, int), int> map = new Dictionary<(int, int, int, int), int>();
    public int ShortestDistance(int[][] grid)
    {
        var candidates = new List<(int x, int y)>();
        var buildings = new HashSet<(int x, int y)>();
        for (var i = 0; i < grid.Length; i++)
            for (var j = 0; j < grid[i].Length; j++)
                if (grid[i][j] == 0)
                    candidates.Add((i, j));
                else if (grid[i][j] == 1)
                    buildings.Add((i, j));


        var res = int.MaxValue;
        foreach (var start in candidates)
        {
            var v = Dis(start, buildings, grid);
            if (v > 0)
                res = Math.Min(res, v);
        }

        return res == int.MaxValue ? -1 : res;
    }

    public int Dis((int x, int y) start, HashSet<(int x, int y)> buildings, int[][] grid)
    {
        var q = new Queue<(int x, int y, int step)>();
        q.Enqueue((start.x, start.y, 0));
        var visited = new int[grid.Length, grid[0].Length];
        visited[start.x, start.y] = 1;
        var dis = 0;
        var count = 0;
        while (q.Any())
        {
            var (x, y, steps) = q.Dequeue();
            if (grid[x][y] == 1)
            {
                //map[(start.x, start.y, x, y)] = steps;
                dis += steps;
                count++;
            }
            else
            {
                foreach (var d in directions)
                {
                    var newx = x + d.x;
                    var newy = y + d.y;
                    if (newx >= 0 && newy >= 0 && newx < grid.Length && newy < grid[0].Length && grid[newx][newy] != 2 && visited[newx, newy] == 0)
                    {
                        q.Enqueue((newx, newy, steps + 1));
                        visited[newx, newy] = 1;
                    }
                }
            }
        }

        return count == buildings.Count ? dis : -1;
    }

}