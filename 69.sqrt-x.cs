public class Solution
{
    public int MySqrt(int x)
    {
        long min = 0;
        long max = x;

        while (min <= max)
        {
            var mid = min + (max - min) / 2;
            var mid_2 = mid * mid;
            if (mid_2 == x)
            {
                return Convert.ToInt32(mid);
            }
            else if (mid_2 > x)
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return  Convert.ToInt32(min - 1);


    }
}
// @lc code=end

