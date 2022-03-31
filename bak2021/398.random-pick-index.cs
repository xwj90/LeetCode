/*
 * @lc app=leetcode id=398 lang=csharp
 *
 * [398] Random Pick Index
 */

// @lc code=start
public class Solution
{

    Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
    Random r = new Random();
    public Solution(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i])) dict[nums[i]] = new List<int>();
            dict[nums[i]].Add(i);
        }
    }

    public int Pick(int target)
    {
        if (dict.ContainsKey(target))
        {
            return dict[target][r.Next(dict[target].Count)];
        }
        return -1;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */
// @lc code=end

