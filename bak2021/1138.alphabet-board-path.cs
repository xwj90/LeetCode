public class Solution
{
    public string AlphabetBoardPath(string target)
    {
        StringBuilder sb = new StringBuilder();
        var board = new char[6][];
        board[0] = new char[] { 'a', 'b', 'c', 'd', 'e' };
        board[1] = new char[] { 'f', 'g', 'h', 'i', 'j' };
        board[2] = new char[] { 'k', 'l', 'm', 'n', 'o' };
        board[3] = new char[] { 'p', 'q', 'r', 's', 't' };
        board[4] = new char[] { 'u', 'v', 'w', 'x', 'y' };
        board[5] = new char[] { 'z' };

        var map = new (int x, int y)[26];

        for (var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[i].Length; j++)
                map[board[i][j] - 'a'] = (i, j);

        var previous = (x: 0, y: 0);
        foreach (var c in target)
        {
            var current = map[c - 'a'];
            
            if (current.y < previous.y) sb.Append('L', previous.y - current.y);
            if (current.x < previous.x) sb.Append('U', previous.x - current.x);
            if (current.x > previous.x) sb.Append('D', current.x - previous.x);            
            if (current.y > previous.y) sb.Append('R', current.y - previous.y);
            sb.Append("!");
            previous = current;
        }
        return sb.ToString();

    }
}
// @lc code=end

