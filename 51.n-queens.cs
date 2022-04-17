public class Solution
{
    public IList<IList<string>> SolveNQueens(int n, char[,] board = null, int row = 0, IList<IList<string>> results = null)
    {
        if (board == null)
        {
            board = new char[n, n];
            for (var i = 0; i < n; i++)
                for (var j = 0; j < n; j++)
                    board[i, j] = '.';
        }
        var temp = results ?? new List<IList<string>>();

        for (var i = 0; i < n; i++)
        {
            board[row, i] = 'Q';
            if (row == n - 1)
            {
                if (isValid(board, n))
                {
                    temp.Add(ToString(board, n));
                }
            }
            else
            {
                if (isValid(board, n))
                {
                    SolveNQueens(n, board, row + 1, temp);
                }
            }

            board[row, i] = '.';
        }

        return temp;
    }

    public bool isValid(char[,] board, int n)
    {
        var rowCount = new int[n];
        var colCount = new int[n];
        var diagnolCount = new int[n * 2];
        var diagnol2Count = new int[n * 2];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (board[i, j] == 'Q')
                {
                    rowCount[i]++;
                    colCount[j]++;
                    diagnolCount[j - i + n - 1]++;
                    diagnol2Count[i + j]++;
                }
            }
        }
        if (rowCount.Any(p => p > 1) || colCount.Any(p => p > 1) || diagnolCount.Any(p => p > 1) || diagnol2Count.Any(p => p > 1))
            return false;
        return true;
    }
    public List<string> ToString(char[,] board, int n)
    {
        var result = new List<string>();
        for (var i = 0; i < n; i++)
        {
            result.Add("");
            for (var j = 0; j < n; j++)
            {
                result[i] += board[i, j];
            }
        }
        return result;
    }
}
// @lc code=end

