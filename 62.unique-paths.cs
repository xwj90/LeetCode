public class Solution
{
    public int UniquePaths(int m, int n)
    {
        if (m > n)
            return UniquePaths(n, m);
        var previous = new int[m];
        var current = new int[m];
        for (var i = 0; i < m; i++)
        {
            previous[i] = 1;
            current[i] = 1;
        }
        for (var j = 1; j < n; j++)
        {
            for (var i = 0; i < m; i++)
            {
                if (i == 0)
                    current[i] = previous[i];
                else
                    current[i] = previous[i] + current[i - 1];
            }
            previous = current;
        }
        return current[current.Length - 1];

    }
}
