public class Solution
{
    public int TotalHammingDistance(int[] nums)
    {
        var total = 0;
        for (var i = 0; i < 32; i++)
        {
            var bitCount = 0;
            for (var j = 0; j < nums.Length; j++)
                bitCount += (nums[j] >> i) & 1;
            total += bitCount * (nums.Length - bitCount);
        }
        return total;
    }

}
// @lc code=end

