/*
 * @lc app=leetcode id=41 lang=csharp
 *
 * [41] First Missing Positive
 */

// @lc code=start
public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        // Base case.
        int contains = 0;
        for (int i = 0; i < n; i++)
            if (nums[i] == 1)
            {
                contains++;
                break;
            }
        if (contains == 0)
            return 1;

        // nums = [1]
        if (n == 1)
            return 2;


        for (int i = 0; i < n; i++)
            if ((nums[i] <= 0) || (nums[i] > n))
                nums[i] = 1;

        for (int i = 0; i < n; i++)
        {
            int a = Math.Abs(nums[i]);
            if (a == n)
                nums[0] = -Math.Abs(nums[0]);
            else
                nums[a] = -Math.Abs(nums[a]);
        }
        for (int i = 1; i < n; i++)
        {
            if (nums[i] > 0)
                return i;
        }

        if (nums[0] > 0)
            return n;

        return n + 1;
    }
}
// @lc code=end

