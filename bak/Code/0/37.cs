using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    /// <summary>
    /// 37. Sudoku Solver
    /// </summary>
    /// <param name="board"></param>
    public void SolveSudoku(char[,] board)
    {
        var s = SolveSudoku(board, 0);

    }
    private bool SolveSudoku(char[,] board, int num)
    {
        var length = board.GetLength(0);
        var i = num / length;
        var j = num % length;
        if (num >= board.Length)
            return true;
        //find all empty slots
        if (board[i, j] == '.')
        {
            var arr = new int[length];
            for (int k = 0; k < length; k++)
            {
                if (board[i, k] != '.')
                    arr[board[i, k] - '1'] = 1;
                if (board[k, j] != '.')
                    arr[board[k, j] - '1'] = 1;
                if (board[(i / 3)*3 + k / 3, (j / 3) * 3 + k % 3] != '.')
                    arr[board[(i / 3) * 3 + k / 3, (j / 3) * 3 + k % 3] - '1'] = 1;
            }
            var candidates = new List<int>();
            for (int k = 0; k < length; k++)
                if (arr[k] == 0)
                    candidates.Add(k + 1);
            if (candidates.Count == 0)
                return false;//no candidates
                             //try
            foreach (int c in candidates)
            {
                board[i, j] = (char)(c + '0');
                var status = SolveSudoku(board, i * length + j + 1);
                if (status)
                    return true;
                board[i, j] = '.';

            }
            return false;
        }
        else
            return SolveSudoku(board, num + 1);


    }
}





