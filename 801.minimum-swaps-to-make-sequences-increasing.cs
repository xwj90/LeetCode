/*
 * @lc app=leetcode id=801 lang=csharp
 *
 * [801] Minimum Swaps To Make Sequences Increasing
 */

// @lc code=start
public class Solution
{
    public int MinSwap(int[] A, int[] B)
    {
        var n1 = 0;
        var s1 = 1;
        for (var i = 1; i < A.Length; ++i)
        {
            var n2 = int.MaxValue;
            var s2 = int.MaxValue;
            if (A[i - 1] < A[i] && B[i - 1] < B[i])
            {
                n2 = n1;
                s2 = s1 + 1;
            }
            if (A[i - 1] < B[i] && B[i - 1] < A[i])
            {
                n2 = Math.Min(n2, s1);
                s2 = Math.Min(s2, n1 + 1);
            }
            n1 = n2;
            s1 = s2;
        }
        return Math.Min(n1, s1);
    }
}
// @lc code=end

