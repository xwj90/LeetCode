public class Solution
{
    public bool Search(int[] nums, int target)
    {
        if (nums.Length == 0) return false;
        var start = 0;
        if (nums[nums.Length - 1] <= nums[0])
        {
            var l = 0;
            var r = nums.Length - 1;
            while (l < r - 1)
            {
                var mid = l + (r - l) / 2;
                if (nums[mid] <= nums[r]) r = mid;
                if (nums[l] <= nums[mid]) l = mid;
            }
            start = r;
        }

        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            var e = nums[(mid + start) % nums.Length];
            if (e == target) return true;
            else if (e < target) left = mid + 1;
            else right = mid - 1;
        }
        return false;
    }
}
// @lc code=end

