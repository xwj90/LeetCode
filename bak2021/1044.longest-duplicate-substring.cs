public class Solution
{
    public string LongestDupSubstring(string S)
    {
        var left = 0;
        var right = S.Length - 1;
        var res = -1;
        var nums = S.Select(p => p - 'a').ToArray();
        while (left <= right)
        {
            var mid = (right + left) / 2;
            var start = Duplicate(nums, mid);
            if (start != -1)
            {
                left = mid + 1;
                res = start;
            }
            else
                right = mid - 1;
        }

        return (res == -1) ? "" : S.Substring(res, left - 1);
    }

    public int Duplicate(int[] nums, int L)
    {
        var dict = new Dictionary<long, int>();
        long mod = 1000007;

        long val = 0;
        for (var i = 0; i < L; i++) val = (val * 26 + nums[i]) % mod;
        dict[val] = 0;

        long pow = 1;
        for (int i = 0; i < L; i++) pow = (pow * 26) % mod;

        for (var start = 1; start <= nums.Length - L; start++)
        {
            val = (val * 26 - nums[start - 1] * pow % mod + mod) % mod;
            val = (val + nums[start + L - 1]) % mod;
            if (dict.ContainsKey(val))
            {
                var oldStart = dict[val];
                var notsame = false;
                for (var j = 0; j < L; j++)
                {
                    if (nums[start + j] != nums[oldStart + j])
                        notsame = true;
                }
                return oldStart;
            }
            dict[val] = start;
        }

        return -1;
    }
}