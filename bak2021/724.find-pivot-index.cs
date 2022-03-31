public class Solution
{
    public int PivotIndex(int[] nums)
    {
        if (nums.Length == 0) return -1;
        var list = new List<int>() { 0 };
        list.AddRange(nums);
        list.Add(0);
        var right = nums.Sum() - list[0];
        var left = list[0];
        for (var i = 1; i < list.Count - 1; i++)
        {
            left += list[i - 1];
            right -= list[i];
            if (left == right) return i-1;
        }
        return -1;
    }
}
// @lc code=end

