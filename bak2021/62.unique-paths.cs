public class Solution
{

    Dictionary<(int, int), int> dict = new Dictionary<(int, int), int>();
    public int UniquePaths(int m, int n)
    {
        return UniquePathsCount(1, 1, m, n);
    }

    public int UniquePathsCount(int x, int y, int m, int n)
    {
        if (x == m && y == n) return 1;
        if (dict.ContainsKey((x, y))) return dict[(x, y)];
        var count = 0;
        if (x < m) count += UniquePathsCount(x + 1, y, m, n);
        if (y < n) count += UniquePathsCount(x, y + 1, m, n);
        dict[(x, y)] = count;
        return count;
    }
}
// @lc code=end

