public class Solution
{
    public void WallsAndGates(int[][] rooms)
    {

        for (var i = 0; i < rooms.Length; i++)
            for (var j = 0; j < rooms[i].Length; j++)
                if (rooms[i][j] == 0)
                    Update(rooms, i, j);
    }
    public void Update(int[][] rooms, int x, int y)
    {
        var q = new Queue<(int x, int y, int v)>();
        q.Enqueue((x, y, 0));
        var visit = new HashSet<(int x, int y)>();
        while (q.Any())
        {
            var (i, j, v) = q.Dequeue();
            if (i >= 0 && j >= 0 && i < rooms.Length && j < rooms[i].Length && rooms[i][j] != -1 && !visit.Contains((i, j)))
            {
                if (rooms[i][j] == int.MaxValue || rooms[i][j] == 0 || v < rooms[i][j])
                {
                    if (rooms[i][j] != 0)
                        rooms[i][j] = v;
                    visit.Add((i, j));
                    q.Enqueue((i - 1, j, v + 1));
                    q.Enqueue((i + 1, j, v + 1));
                    q.Enqueue((i, j - 1, v + 1));
                    q.Enqueue((i, j + 1, v + 1));
                }
            }
        }
    }
}