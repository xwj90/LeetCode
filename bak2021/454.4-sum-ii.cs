/*
 * @lc app=leetcode id=454 lang=csharp
 *
 * [454] 4Sum II
 */

// @lc code=start
public class Solution
{
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < A.Length; i++)
            for (var j = 0; j < B.Length; j++)
                if (!dict.ContainsKey(A[i] + B[j])) dict[A[i] + B[j]] = 1;
                else dict[A[i] + B[j]]++;

        var dict2 = new Dictionary<int, int>();
        for (var i = 0; i < C.Length; i++)
            for (var j = 0; j < D.Length; j++)
                if (!dict2.ContainsKey(C[i] + D[j])) dict2[C[i] + D[j]] = 1;
                else dict2[C[i] + D[j]]++;

        var res = 0;
        foreach (var item in dict)
        {
            if (dict2.ContainsKey(-item.Key))
            {
                res += item.Value * dict2[-item.Key];
            }
        }
        return res;
    }
}
// @lc code=end

