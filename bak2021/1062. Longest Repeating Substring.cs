public class Solution
{
    public int LongestRepeatingSubstring(string S)
    {
        var nums = S.Select(p => p - 'a').ToArray();
        var modulus = (long)Math.Pow(2, 24);
        var left = 1;
        var right = S.Length;
        while (left <= right) //binary search to get length
        {
            var l = left + (right - left) / 2;
            if (Search(l, modulus, nums) != -1)
                left = l + 1;
            else
                right = l - 1;
        }

        return left - 1;
    }
    public int Search(int L, long modulus, int[] nums, int a = 26)
    {
        long h = 0;
        for (var i = 0; i < L; ++i) h = (h * a + nums[i]) % modulus;
        var seen = new HashSet<long>();
        seen.Add(h);

        long aL = 1;
        for (int i = 1; i <= L; ++i) aL = (aL * a) % modulus;

        for (var start = 1; start < nums.Length - L + 1; start++)
        {
            h = (h * a - nums[start - 1] * aL % modulus + modulus) % modulus;
            h = (h + nums[start + L - 1]) % modulus;
            if (seen.Contains(h)) return start;
            seen.Add(h);
        }
        return -1;
    }
}