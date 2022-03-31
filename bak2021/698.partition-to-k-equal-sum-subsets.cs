public class Solution
{
    public bool CanPartitionKSubsets(int[] nums, int k)
    {
        var sum = nums.Sum();
        if (sum % k > 0) return false;
        var target = sum / k;
        Array.Sort(nums);
        if (nums[nums.Length - 1] > target) return false;
        var sameValueCount = nums.Count(p => p == target);

        return search(new int[k - sameValueCount], nums.Length - 1 - sameValueCount, nums, target);
    }

    public bool search(int[] groups, int row, int[] nums, int target)
    {
        if (row < 0) return true;
        var v = nums[row--];
        for (var i = 0; i < groups.Length; i++)
        {
            if (groups[i] + v <= target)
            {
                groups[i] += v;
                if (search(groups, row, nums, target)) return true;
                groups[i] -= v;
            }
            if (groups[i] == 0) break;
        }
        return false;

    }
}
// @lc code=end

