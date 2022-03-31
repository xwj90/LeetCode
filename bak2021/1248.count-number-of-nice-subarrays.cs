public class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        return most(nums, k) - most(nums, k - 1);
    }

    public int most(int[] nums, int k)
    {
        var res = 0;
        var i = 0;
        for (var j = 0; j < nums.Length; j++)
        {
            k -= nums[j] % 2;
            while (k < 0)
                k += nums[i++] % 2;
            res += j - i + 1; // 1+2+3+...+n, count number while ending is j
        }
        return res;
    }

}
// @lc code=end

