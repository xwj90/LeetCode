public class Solution
{
    public void SolveSudoku(char[][] board)
    {

        var n = board.Length;
        var rows = new int[n, n];
        var columns = new int[n, n];
        var blocks = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (board[i][j] != '.')
                {
                    var num = board[i][j] - '1';
                    rows[i, num] = 1;
                    columns[j, num] = 1;
                    blocks[i / 3 * 3 + j / 3, num] = 1;
                }
            }
        }
        DFS(board, rows, columns, blocks);
    }
    public bool DFS(char[][] board, int[,] rows, int[,] columns, int[,] blocks, int x = 0, int y = 0)
    {
        var n = board.GetLength(0);
        var x1 = (x + 1) % n;
        var y1 = y + (x == n - 1 ? 1 : 0);
        if (board[x][y] != '.')
        {
            if (x == n - 1 && y == n - 1) //last element
                return true;
            else if (DFS(board, rows, columns, blocks, x1, y1))
                return true;
        }
        else
        {
            for (var v = 0; v < n; v++)
            {
                if (rows[x, v] == 0 && columns[y, v] == 0 && blocks[x / 3 * 3 + y / 3, v] == 0)
                {
                    board[x][y] = (char)('1' + v);
                    rows[x, v] = 1;
                    columns[y, v] = 1;
                    blocks[x / 3 * 3 + y / 3, v] = 1;
                    if (x == n - 1 && y == n - 1)//last element
                        return true;
                    else if (DFS(board, rows, columns, blocks, x1, y1))
                        return true;
                    rows[x, v] = 0;
                    columns[y, v] = 0;
                    blocks[x / 3 * 3 + y / 3, v] = 0;
                    board[x][y] = '.';
                }
            }
        }
        return false;
    }
}
// @lc code=end

