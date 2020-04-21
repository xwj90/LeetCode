public class Solution
{
    public int TwoSumLessThanK(int[] A, int K)
    {
        Array.Sort(A);
        var left = 0;
        var right = A.Length - 1;
        var res = -1;
        while (left < right)
        {
            var sum = A[left] + A[right];
            if (sum >= K)
            {
                right--;
            }
            else
            {
                left++;
                res = Math.Max(res, sum);
            }
        }
        return res;
    }
}