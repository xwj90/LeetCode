using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        var board = new string[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                board[i, j] = ".";
        var result = new List<IList<string>>();
        SolveNQueens_DFS(board, 0, result);
        return result;
    }

    private void SolveNQueens_DFS(string[,] board, int y, List<IList<string>> res)
    {
        if (y == board.GetLength(0))
        {
            res.Add(SolveNQueens_Construct(board));
            return;
        }
        for (int x = 0; x < board.GetLength(0); x++)
            if (SolveNQueens_Validate(board, x, y))
            {
                board[x, y] = "Q";
                SolveNQueens_DFS(board, y + 1, res);
                board[x, y] = ".";
            }

    }
    private bool SolveNQueens_Validate(string[,] board, int x, int y)
    {

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (board[i, j] == "Q" && (x + j == y + i || x + y == i + j || x == i))
                    return false;
            }
        }

        return true;
    }

    private IList<string> SolveNQueens_Construct(string[,] board)
    {
        List<String> res = new List<string>();
        for (int i = 0; i < board.GetLength(0); i++)
        {
            var s = "";
            for (int j = 0; j < board.GetLength(0); j++)
                s += board[i, j];
            res.Add(s);
        }
        return res;
    }


}
