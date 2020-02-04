public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var release1 = 0;
        var release2 = 0;
        var hold1 = int.MinValue;
        var hold2 = int.MinValue;
         foreach (var p in prices)
        {
            release2 = Math.Max(release2, hold2 + p);
            hold2 = Math.Max(hold2, release1 - p);
            release1 = Math.Max(release1, hold1 + p);
            hold1 = Math.Max(hold1, -p);
        }
        return release2;
    }
}
// @lc code=end

