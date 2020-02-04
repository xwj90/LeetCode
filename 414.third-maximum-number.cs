public class Solution
{
    public int ThirdMax(int[] nums)
    {
        int? max1 = null;
        int? max2 = null;
        int? max3 = null;
        foreach (var n in nums)
        {
            if (n == max1 || n == max2 || n == max3) continue;
            if (max1 == null || n > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = n;
            }
            else if (max2 == null || n > max2)
            {
                max3 = max2;
                max2 = n;
            }
            else if (max3 == null || n > max3)
            {
                max3 = n;
            }            
        }
        return max3 == null ? max1.Value : max3.Value;
    }
}
// @lc code=end

