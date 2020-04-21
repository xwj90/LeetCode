public class Solution
{
    private List<(int x, int y)> directions = new List<(int, int)>() { (1, 0), (-1, 0), (0, 1), (0, -1) };
    public int MaximumMinimumPath(int[][] A)
    {
        var set = new SortedSet<(int score, int i, int j)>() { (A[0][0], 0, 0) }; //start
        var maxScore = A[0][0];
        A[0][0] = -1; //visited
        while (set.Any())
        {
            var max = set.Max;
            set.Remove(max);
            maxScore = Math.Min(maxScore, max.score);
            if (max.i == A.Length - 1 && max.j == A[0].Length - 1) //destination
                break;
            foreach (var (x, y) in directions)
            {
                var i = max.i + x;
                var j = max.j + y;
                if (i >= 0 && j >= 0 && i < A.Length && j < A[0].Length && A[i][j] >= 0)
                {
                    set.Add((A[i][j], i, j));
                    A[i][j] = -1;
                }
            }
        }

        return maxScore;
    }
}
