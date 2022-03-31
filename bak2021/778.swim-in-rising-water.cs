public class Solution
{
    int[] parents;
    int X;
    int Y;
    Random random = new Random();
    public int SwimInWater(int[][] grid)
    {
        X = grid.Length;
        Y = grid[0].Length;
        parents = new int[X * Y];
        var dict = new Dictionary<int, List<(int i, int j)>>();
        //n
        for (var i = 0; i < X; i++)
        {
            for (var j = 0; j < Y; j++)
            {
                parents[GetId(i, j)] = GetId(i, j);

                if (!dict.ContainsKey(grid[i][j])) dict[grid[i][j]] = new List<(int i, int j)>();
                dict[grid[i][j]].Add((i, j));
            }
        }

        var times = dict.Keys.OrderBy(p => p); //n log(n)
        foreach (var t in times)
        {
            foreach (var (i, j) in dict[t])
                Connect(grid, i, j); //o(h)
            if (GetParent(0, 0) == GetParent(X - 1, Y - 1)) //o(h)
                return t;
        }
        return -1;
    }
    private void Connect(int[][] grid, int i, int j)
    {
        if (i > 0 && grid[i - 1][j] <= grid[i][j]) Connect(i, j, i - 1, j);
        if (i < X - 1 && grid[i + 1][j] <= grid[i][j]) Connect(i, j, i + 1, j);
        if (j > 0 && grid[i][j - 1] <= grid[i][j]) Connect(i, j, i, j - 1);
        if (j < Y - 1 && grid[i][j + 1] <= grid[i][j]) Connect(i, j, i, j + 1);
    }

    private void Connect(int i1, int j1, int i2, int j2)
    {
        var leftParent = GetParent(i1, j1);
        var rightParent = GetParent(i2, j2);

        if (leftParent != rightParent)
            if (random.Next(2) == 0)
                this.parents[leftParent] = rightParent;
            else
                this.parents[rightParent] = leftParent;
    }

    private int GetParent(int i, int j)
    {

        var current = GetId(i, j);
        while (this.parents[current] != current)
            current = this.parents[current];

        return current;
    }

    private int GetId(int i, int j)
    {
        return i * Y + j;
    }

}
// @lc code=end

