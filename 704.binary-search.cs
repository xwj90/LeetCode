public class Solution
{
    public int Search(int[] nums, int target)
    {
        // var r = nums.ToList().BinarySearch(target);
        // if (r >= 0) return r;
        // else return -1;

        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] > target) right = mid - 1;
            else if (nums[mid] < target) left = mid + 1;
        }
        return -1;
    }
}
// @lc code=end

