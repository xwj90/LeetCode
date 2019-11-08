using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class SudokuHelper
    {
        public static bool Check(char[,] board)
        {
            if (board.GetLength(0) != board.GetLength(1))
                return false;
            if (board.Any(p => p == '.'))
                return false;
            var length = board.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                var a = new int[length];
                var b = new int[length];

                for (int j = 0; j < length; j++)
                {
                    a[board[i, j] - '1'] = 1;
                    b[board[j, i] - '1'] = 1;
                }
                if (a.Any(p => p == 0))
                    return false;
                if (b.Any(p => p == 0))
                    return false;
            }
            for (int i = 0; i < length / 3; i++)
            {
                for (int j = 0; j < length / 3; j++)
                {
                    var a = new int[length];
                    for (int k = 0; k < length; k++)
                    {
                        a[board[i * 3 + k / 3, j * 3 + k % 3] - '1'] = 1;
                    }
                    if (a.Any(p => p == 0))
                        return false;
                }

            }


            return true;
        }
    }
}