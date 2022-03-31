public class Solution
{
    public int[][] IntervalIntersection(int[][] A, int[][] B)
    {
        var i = 0;
        var j = 0;

        var res = new List<int[]>();

        while (i < A.Length && j < B.Length)
        {
            var left = Math.Max(A[i][0], B[j][0]);
            var right = Math.Min(A[i][1], B[j][1]);
            if (right >= left)
                res.Add(new int[] { left, right });

            if (A[i][1] < B[j][1])
                i++;
            else
                j++;

        }
        return res.ToArray();
    }
}
// @lc code=end

