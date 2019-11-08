using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public bool IsValidSudoku(char[,] board)
    {
        int[] rows = new int[9];
        int[] cols = new int[9];
        int[,] cells = new int[3, 3];
        for (int i = 0; i < board.GetLength(0); i++)
            for (int j = 0; j < board.GetLength(1); j++)
                if (board[i, j] != '.')
                {
                    var bit = 1 << (board[i, j] - '1');
                    if ((rows[i] & bit) != 0 || (cols[j] & bit) != 0 || (cells[i / 3, j / 3] & bit) != 0)
                        return false;
                    rows[i] |= bit;
                    cols[j] |= bit;
                    cells[i / 3, j / 3] |= bit;
                }
        return true;
    }
}





