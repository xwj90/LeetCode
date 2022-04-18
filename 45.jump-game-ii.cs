public class Solution
{
    public int Jump(int[] nums, int start = 0, int[] steps = null)
    {
        steps = steps ?? new int[nums.Length];
        if (start >= nums.Length - 1) return 0;
        if (steps[start] > 0) return steps[start];

        var step = nums.Length + 1;
        for (var i = nums[start]; i > 0; i--)
        {
            step = Math.Min(step, Jump(nums, start + i, steps) + 1);
        }
        steps[start] = step;
        return step;
    }
}

