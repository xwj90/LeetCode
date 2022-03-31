public class TicTacToe
{
    int[,] rows;
    int[,] columns;
    int n;
    int[] diagonal1;
    int[] diagonal2;

    /** Initialize your data structure here. */
    public TicTacToe(int n)
    {
        this.n = n;
        this.rows = new int[3, n];
        this.columns = new int[3, n];
        this.diagonal1 = new int[3];
        this.diagonal2 = new int[3];
    }

    /** Player {player} makes a move at ({row}, {col}).
        @param row The row of the board.
        @param col The column of the board.
        @param player The player, can be either 1 or 2.
        @return The current winning condition, can be either:
                0: No one wins.
                1: Player 1 wins.
                2: Player 2 wins. */
    public int Move(int row, int col, int player)
    {
        this.rows[player, row]++;
        this.columns[player, col]++;
        if (row == col) this.diagonal1[player]++;
        if (row + col == n - 1) this.diagonal2[player]++;

        for (var i = 0; i < n; i++)
        {
            if ((rows[player, i] == n) || columns[player, i] == n)
            {
                return player;
            }
        }
        if (this.diagonal1[player] == n || this.diagonal2[player] == n)
        {
            return player;
        }

        return 0;
    }
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */
