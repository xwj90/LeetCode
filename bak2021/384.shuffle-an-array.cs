/*
 * @lc app=leetcode id=384 lang=csharp
 *
 * [384] Shuffle an Array
 */

// @lc code=start
public class Solution
{
    private Random random = new Random();
    private int[] nums;
    public Solution(int[] nums)
    {
        this.nums = nums;
    }

    /** Resets the array to its original configuration and return it. */
    public int[] Reset()
    {
        return nums;
    }

    /** Returns a random shuffling of the array. */
    public int[] Shuffle()
    {
        var res = new int[nums.Length];
        for (var i = 0; i < res.Length; i++) res[i] = nums[i];

        for (var i = 1; i < res.Length; i++)
        {
            var swap = random.Next(i + 1);
            var temp = res[i];
            res[i] = res[swap];
            res[swap] = temp;
        }
        return res;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
// @lc code=end

