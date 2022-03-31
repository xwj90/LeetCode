public class Solution
{
    public int Reverse(int x)
    {
        long val = Math.Abs((long)x);
        long result = 0;
        while (val > 0)
        {
            var v = val % 10;
            val = val / 10;
            result = result * 10 + v;
        }
        if (x < 0)
            result = -result;

        if (result >= Int32.MaxValue || result <= Int32.MinValue)
            return 0;
        return (int)result;
    }
}
// @lc code=end

