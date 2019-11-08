using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public void Solve(char[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            Solve_Set(board, i, 0);
            Solve_Set(board, i, board.GetLength(1) - 1);
        }
        for (int j = 0; j < board.GetLength(1); j++)
        {
            Solve_Set(board, 0, j);
            Solve_Set(board, board.GetLength(0) - 1, j);
        }
        for (int i = 0; i < board.GetLength(0); i++)
            for (int j = 0; j < board.GetLength(1); j++)
                if (board[i, j] == 'O')
                    board[i, j] = 'X';

        for (int i = 0; i < board.GetLength(0); i++)
            for (int j = 0; j < board.GetLength(1); j++)
                if (board[i, j] == 'E')
                    board[i, j] = 'O';
    }
    private void Solve_Set(char[,] board, int i, int j)
    {
        if (i >= 0 && i < board.GetLength(0) && j >= 0 && j < board.GetLength(1) && board[i, j] == 'O')
        {
            board[i, j] = 'E';
            Solve_Set(board, i + 1, j);
            Solve_Set(board, i - 1, j);
            Solve_Set(board, i, j + 1);
            Solve_Set(board, i, j - 1);
        }
    }
}