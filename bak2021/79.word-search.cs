public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        var starts = new List<(int, int)>();
        for (var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[0].Length; j++)
                if (board[i][j] == word[0])
                    starts.Add((i, j));

        foreach (var (x, y) in starts)
        {
            var path = new HashSet<(int, int)>();
            if (Exist(board, word, (x, y), path)) return true;
        }

        return false;
    }

    public bool Exist(char[][] board, string word, (int, int) position, HashSet<(int, int)> path)
    {
        var x = position.Item1;
        var y = position.Item2;
        if (word.Length == 0) return true;
        if (x < 0 || x >= board.Length) return false;
        if (y < 0 || y >= board[0].Length) return false;
        if (path.Contains(position)) return false;

        if (board[x][y] == word[0])
        {
            path.Add(position);
            if (Exist(board, word.Substring(1), (x + 1, y), path)) return true;
            if (Exist(board, word.Substring(1), (x, y + 1), path)) return true;
            if (Exist(board, word.Substring(1), (x - 1, y), path)) return true;
            if (Exist(board, word.Substring(1), (x, y - 1), path)) return true;
            path.Remove(position);
        }

        return false;
    }
}
// @lc code=end

