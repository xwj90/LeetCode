/*
 * @lc app=leetcode id=264 lang=csharp
 *
 * [264] Ugly Number II
 */
public class Solution
{
    public int NthUglyNumber(int n)
    {
        if (n <= 0) return 0;

        var t2 = 0;
        var t3 = 0;
        var t5 = 0;
        Dictionary<int, int> k = new Dictionary<int, int>();
        k[0] = 1;
        for (int i = 1; i < n; i++)
        {
            k[i] = Math.Min(k[t2] * 2, Math.Min(k[t3] * 3, k[t5] * 5));
            if (k[i] == k[t2] * 2) t2++;
            if (k[i] == k[t3] * 3) t3++;
            if (k[i] == k[t5] * 5) t5++;
        }
        return k[n - 1];
    }
}

