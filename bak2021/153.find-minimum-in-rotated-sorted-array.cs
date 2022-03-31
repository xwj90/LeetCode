public class Solution
{
    public int FindMin(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];

        var left = 0;
        var right = nums.Length - 1;

        if (nums[right] > nums[left])
            return nums[0];

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] > nums[mid + 1])
                return nums[mid + 1];
            if (nums[mid - 1] > nums[mid])
                return nums[mid];
            if (nums[mid] > nums[0])
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
// @lc code=end

