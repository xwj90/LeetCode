/*
 * @lc app=leetcode id=747 lang=csharp
 *
 * [747] Largest Number At Least Twice of Others
 */

// @lc code=start
public class Solution
{
    public int DominantIndex(int[] nums)
    {
        int maxIndex = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] > nums[maxIndex])
                maxIndex = i;
        }
        for (int i = 0; i < nums.Length; ++i)
        {
            if (maxIndex != i && nums[maxIndex] < 2 * nums[i])
                return -1;
        }
        return maxIndex;
    }
}
// @lc code=end

