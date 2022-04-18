public class Solution
{
    public bool CanJump(int[] nums, int start = 0, bool?[] status = null)
    {
        status = status ?? new bool?[nums.Length];
        if (start >= nums.Length - 1)
            return true;
        if (status[start].HasValue)
            return status[start].Value;
        for (var i = nums[start]; i > 0; i--)
        {
            if (CanJump(nums, start + i, status))
            {
                status[start] = true;
                return true;
            }
        }
        status[start] = false;
        return false;
    }
}

