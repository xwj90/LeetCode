public class Solution
{
    List<(int x, int y)> directions = new List<(int x, int y)>() { (1, 0), (-1, 0), (0, 1), (0, -1) };
    public IList<string> FindWords(char[][] board, string[] words)
    {
        var idx = new List<(int x, int y)>[256];
        for (var i = 0; i < idx.Length; i++)
            idx[i] = new List<(int, int)>();

        for (var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[i].Length; j++)
                idx[board[i][j]].Add((i, j));

        var res = new HashSet<string>();
        foreach (var word in words)
            foreach (var (x, y) in idx[word[0]])
                if (DFS(x, y, board, word, 0, new int[board.Length, board[0].Length]))
                    res.Add(word);


        return res.ToList();
    }
    public bool DFS(int x, int y, char[][] board, string word, int i, int[,] visited)
    {
        if (x >= 0 && y >= 0 && x < board.Length && y < board[0].Length && board[x][y] == word[i] && visited[x, y] == 0)
        {
            if (i == word.Length - 1) return true;
            else
            {
                visited[x, y] = 1;
                foreach (var d in directions)
                {
                    if (DFS(x + d.x, y + d.y, board, word, i + 1, visited))
                        return true;
                }
                visited[x, y] = 0;
            }
        }
        return false;
    }

}
// @lc code=end

