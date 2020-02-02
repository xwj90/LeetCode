public class Solution
{

    public int SplitArray(int[] nums, int m)
    {
        int max = 0;
        long sum = 0;
        foreach (var n in nums)
        {
            max = Math.Max(max, n);
            sum += n;
        }
        if (m == 1) return Convert.ToInt32(sum);
        long l = max;
        long r = sum;
        while (l <= r)
        {
            var mid = (l + r) / 2;
            if (valid(mid, nums, m)) r = mid - 1;
            else l = mid + 1;
        }
        return Convert.ToInt32(l);
    }

    public bool valid(long target, int[] nums, int m)
    {
        var count = 1;
        long total = 0;
        foreach (var n in nums)
        {
            total += n;
            if (total > target)
            {
                total = n;
                count++;
                if (count > m) return false;
            }
        }
        return true;
    }
}
// @lc code=end

