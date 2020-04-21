public class Solution
{
    private List<(int x, int y, char direction)> directions = new List<(int, int, char)>() { (0, 1, 'r'), (0, -1, 'l'), (1, 0, 'u'), (-1, 0, 'd') };
    public int NumDistinctIslands(int[][] grid)
    {
        var uniqueShapes = new HashSet<string>(); // Unique shpes. 

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    grid[i][j] = 0;
                    var shape = new List<char>() { '0' };
                    dfsTraversal(i, j, grid, shape);
                    uniqueShapes.Add(new string(shape.ToArray()));
                }
            }
        }

        return uniqueShapes.Count;
    }

    private void dfsTraversal(int x, int y, int[][] grid, List<char> shape)
    {
        foreach (var item in directions)
        {
            int nx = x + item.x;
            int ny = y + item.y;
            if (nx >= 0 && ny >= 0 && nx < grid.Length && ny < grid[0].Length)
            {
                if (grid[nx][ny] == 1)
                {
                    grid[nx][ny] = 0;
                    shape.Add(item.direction); //step direction
                    dfsTraversal(nx, ny, grid, shape);
                }
            }
        }
        shape.Add('_');
    }
}