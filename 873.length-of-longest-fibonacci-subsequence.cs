public class Solution
{
    public int LenLongestFibSubseq(int[] A)
    {
        var longest = new Dictionary<(int, int), int>();
        var ind = new Dictionary<int, int>();
        var res = 0;
        for (var i = 0; i < A.Length; i++)
            ind[A[i]] = i;

        for (var k = 0; k < A.Length; k++)
            for (var j = 0; j < k; j++)
            {
                if (ind.TryGetValue(A[k] - A[j], out var i) && i < j)
                {

                    if (!longest.TryGetValue((i, j), out var candidate))
                    {
                        candidate = 2;
                    }

                    candidate++;
                    longest[(j, k)] = candidate;
                    res = Math.Max(res, candidate);
                }
            }
        return res >= 3 ? res : 0;
    }
}
// @lc code=end

