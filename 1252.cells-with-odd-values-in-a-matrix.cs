/*
 * @lc app=leetcode id=1252 lang=csharp
 *
 * [1252] Cells with Odd Values in a Matrix
 */

// @lc code=start
public class Solution
{
    public int OddCells(int n, int m, int[][] indices)
    {
        var r = new int[n];
        var c = new int[m];
        foreach (var idx in indices)
        {
            r[idx[0]]++;
            c[idx[1]]++;
        }
        var count = 0;
        for (var i = 0; i < n; i++)
            for (var j = 0; j < m; j++)
                count += (r[i] + c[j]) % 2;
        return count;
    }
}
// @lc code=end

