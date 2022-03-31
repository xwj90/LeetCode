public class Solution
{
    public int GetNextNumber(int n)
    {
        var v = 0;
        while (n > 0)
        {
            v += (n % 10) * (n % 10);
            n = n / 10;
        }

        return v;
    }
    public bool IsHappy(int n)
    {
        var hs = new HashSet<int>();

        while (!hs.Contains(n))
        {
            if (n == 1)
                return true;

            hs.Add(n);
            n = this.GetNextNumber(n);
        }

        return false;
    }


}
// @lc code=end

