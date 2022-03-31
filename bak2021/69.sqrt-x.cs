public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0) return 0;
        long left = 0;
        long right = int.MaxValue;
        while (true)
        {
            var mid = (left + right) / 2;
            if (mid > x / mid)
            {
                right = mid - 1;
            }
            else
            {
                if (mid + 1 > x / (mid + 1)) return Convert.ToInt32(mid);
                left = mid + 1;
            }
        }
    }
}
// @lc code=end

