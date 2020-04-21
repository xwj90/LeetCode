public class Solution
{
    public void SolveSudoku(char[][] board)
    {
        var count = board.Sum(p => p.Length);
        SolveSudoku(board, 0, count);
    }
    private bool SolveSudoku(char[][] board, int num, int count)
    {
        var length = board.Length;
        var i = num / length;
        var j = num % length;
        if (num >= count) return true;

        if (board[i][j] == '.')
        {
            var arr = new int[length];
            for (var k = 0; k < length; k++)
            {
                if (board[i][k] != '.') arr[board[i][k] - '1'] = 1;
                if (board[k][j] != '.') arr[board[k][j] - '1'] = 1;
                if (board[(i / 3) * 3 + k / 3][(j / 3) * 3 + k % 3] != '.')
                    arr[board[(i / 3) * 3 + k / 3][(j / 3) * 3 + k % 3] - '1'] = 1;
            }
            var candidates = new List<char>();
            for (int k = 0; k < length; k++)
                if (arr[k] == 0)
                    candidates.Add((char)(k + '1'));

            if (!candidates.Any()) return false;
            foreach (var c in candidates)
            {
                board[i][j] = c;
                if (SolveSudoku(board, i * length + j + 1, count)) return true;
                board[i][j] = '.';
            }
            return false;
        }
        else
        {
            return SolveSudoku(board, num + 1, count);
        }
    }
}
// @lc code=end

