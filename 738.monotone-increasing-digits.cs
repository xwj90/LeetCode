public class Solution
{
    public int MonotoneIncreasingDigits(int n)
    {
        var s = n.ToString().ToCharArray().Select(p => (int)p - '0').ToArray();
        int flag = s.Length;
        for (int i = s.Length - 1; i > 0; i--)
        {
            if (s[i - 1] > s[i])
            {
                flag = i;
                s[i - 1]--;
            }
        }

        var sum = 0;
        var current = 1;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sum += (i >= flag ? 9 : s[i]) * current;
            current*=10;
        }
       return sum;
    }
}
// @lc code=end

