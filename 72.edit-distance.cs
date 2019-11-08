/*
 * @lc app=leetcode id=72 lang=csharp
 *
 * [72] Edit Distance
 */
public class Solution
{
    Dictionary<(string, string), int> dict = new Dictionary<(string, string), int>();
    public int MinDistance(string word1, string word2)
    {
        var m = word1.Length;
        var n = word2.Length;
        int[,] cost = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
            cost[i, 0] = i;
        for (int i = 0; i <= n; i++)
            cost[0, i] = i;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (word1[i] == word2[j])
                {
                    cost[i + 1, j + 1] = cost[i, j];
                }
                else
                {
                    int a = cost[i, j];
                    int b = cost[i, j + 1];
                    int c = cost[i + 1, j];
                    cost[i + 1, j + 1] = Math.Min(Math.Min(a, b), c) + 1;
                }
            }
        }
        return cost[m, n];
    }
}

