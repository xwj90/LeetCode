public class Solution
{
    Dictionary<(int i, int j, int k), BigInteger> dict = new Dictionary<(int i, int j, int k), BigInteger>();
    public int[] MaxNumber(int[] nums1, int[] nums2, int k)
    {
        var v = MaxNumber(nums1, nums2, 0, 0, k);
        var res = new List<int>();
        while (v >= 1)
        {
            Console.WriteLine(v);
            var m = v % 10;
            res.Add((int)m);
            v = v / 10;
        }
        res.Reverse();
        return res.ToArray();
    }
    public BigInteger MaxNumber(int[] nums1, int[] nums2, int i, int j, int k)
    {
        if (k == 0) return 0;
        if (nums1.Length - i + nums2.Length - j < k) return int.MinValue;
        if (dict.ContainsKey((i, j, k))) return dict[(i, j, k)];
        BigInteger v = 0;
        if (i < nums1.Length)
        {
            v = BigInteger.Max(v, nums1[i] * BigInteger.Pow(10, k - 1) + MaxNumber(nums1, nums2, i + 1, j, k - 1));
            if (nums1.Length - i + nums2.Length - j > k)
                v = BigInteger.Max(v, MaxNumber(nums1, nums2, i + 1, j, k));
        }
        if (j < nums2.Length)
        {
            v = BigInteger.Max(v, nums2[j] * BigInteger.Pow(10, k - 1) + MaxNumber(nums1, nums2, i, j + 1, k - 1));
            if (nums1.Length - i + nums2.Length - j > k)
                v = BigInteger.Max(v, MaxNumber(nums1, nums2, i, j + 1, k));
        }

        dict[(i, j, k)] = v;
        return v;
    }
}
// @lc code=end

