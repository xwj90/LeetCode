/*
 * @lc app=leetcode id=456 lang=csharp
 *
 * [456] 132 Pattern
 */

// @lc code=start
public class Solution
{
    public bool Find132pattern(int[] nums)
    {
        if (nums.Length < 3) return false;
        var stack = new Stack<int>();
        var min = new int[nums.Length];
        min[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
            min[i] = Math.Min(min[i - 1], nums[i]);

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] > min[i]) // smaller item in left
            {
                while (stack.Any() && stack.Peek() <= min[i])
                    stack.Pop();
                if (stack.Any() && stack.Peek() < nums[i])
                    return true;
                stack.Push(nums[i]);
            }
        }
        return false;
    }
}
// @lc code=end

