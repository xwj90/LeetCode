/*
 * @lc app=leetcode id=503 lang=csharp
 *
 * [503] Next Greater Element II
 */

// @lc code=start
public class Solution
{
    public int[] NextGreaterElements(int[] nums)
    {
        var res = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
            res[i] = -1;
        var stack = new Stack<int>();
        stack.Push(0);
        for (var j = 1; j < nums.Length * 2; j++)
        {
            var i = j % nums.Length;
            while (stack.Any() && nums[stack.Peek()] < nums[i])
                res[stack.Pop()] = nums[i];
            stack.Push(i);
        }
        return res;
    }
}
// @lc code=end

