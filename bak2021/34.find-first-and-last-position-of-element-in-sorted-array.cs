public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        var targetRange = new int[] { -1, -1 };
        int leftIdx = extremeInsertionIndex(nums, target, true);

        if (leftIdx == nums.Length || nums[leftIdx] != target)
        {
            return targetRange;
        }

        targetRange[0] = leftIdx;
        targetRange[1] = extremeInsertionIndex(nums, target, false) - 1;

        return targetRange;

    }
    private int extremeInsertionIndex(int[] nums, int target, bool left)
    {
        var start = 0;
        var end = nums.Length;
        while (start < end)
        {
            var mid = (end + start) / 2;
            if (nums[mid] > target || (left && target == nums[mid])) end = mid;
            else start = mid + 1;
        }
        return start;
    }
}
// @lc code=end

