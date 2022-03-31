/*
 * @lc app=leetcode id=454 lang=csharp
 *
 * [454] 4Sum II
 */

// @lc code=start
public class Solution
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        var count = 0;
        var dict = new Dictionary<int, int>();
        foreach (var n1 in nums1)
            foreach (var n2 in nums2)
            {
                var sum = n1 + n2;
                dict[sum] = dict.ContainsKey(sum) ? dict[sum] + 1 : 1;
            }

        foreach (var n1 in nums3)
            foreach (var n2 in nums4)
            {
                var target = 0 - n1 - n2;
                if (dict.ContainsKey(target))
                {
                    count += dict[target];
                }
            }
            
        return count;

    }
}
// @lc code=end

