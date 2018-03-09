using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool Exist(char[,] board, string word)
    {
      
        for (int i = 0; i < board.GetLength(0); i++)
            for (int j = 0; j < board.GetLength(1); j++)
                if (Exist(board, i, j, word))
                    return true;
        return false;
    }

    private bool Exist(char[,] board, int i, int j, string v)
    {
        if (board[i, j] == v[0])
        {
            if (v.Length == 1)
                return true;
            board[i, j] = '.';
            if (i > 0 && Exist(board, i - 1, j, v.Substring(1)))
                return true;
            if (j > 0 && Exist(board, i, j - 1, v.Substring(1)))
                return true;
            if (i < board.GetLength(0) - 1 && Exist(board, i + 1, j, v.Substring(1)))
                return true;
            if (j < board.GetLength(1) - 1 && Exist(board, i, j + 1, v.Substring(1)))
                return true;
            board[i, j] = v[0];
            return false;
        }
        return false;
    }
}
