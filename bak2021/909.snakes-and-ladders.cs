public class Solution
{
    public int SnakesAndLadders(int[][] board)
    {
        var n = board.Length;
        var q = new Queue<(int, int)>();
        q.Enqueue((1, 0));
        var visited = new HashSet<int>();
        visited.Add(1);
        while (q.Any())
        {
            var (x, step) = q.Dequeue();
            for (var i = x + 1; i <= x + 6; i++)
            {
                var loc = i;
                var a = (loc - 1) / n;
                var b = (loc - 1) % n;
                var next = board[n - 1 - a][n - 1 - b];
                if (a % 2 == 0)
                    next = board[n - 1 - a][b];
                if (next > 0)
                    loc = next;

                if (loc == n * n)
                    return step + 1; 
                if (!visited.Contains(loc))
                {
                    visited.Add(loc);
                    q.Enqueue((loc, step + 1));
                }
            }
        }
        return -1;
    }
}