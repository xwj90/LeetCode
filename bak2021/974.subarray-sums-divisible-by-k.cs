
public class Solution
{
    public int SubarraysDivByK(int[] A, int K)
    {
        int[] sum = new int[A.Length + 1];
        for (var i = 0; i < A.Length; i++)
            sum[i + 1] = sum[i] + A[i];
        return sum.GroupBy(p => (p % K + K) % K) // take care of negative number
                .Sum(p => p.Count() * (p.Count() - 1) / 2); //here is combination, if mod are same value, they are valid combination
    }
}

