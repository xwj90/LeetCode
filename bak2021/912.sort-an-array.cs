public class Solution
{
    private Random r = new Random();
    public IList<int> SortArray(int[] nums)
    {
        var res = new List<int>();
        var result = new int[100001];
        foreach (var n in nums)
            result[n + 50000]++;
        for (var i = 0; i < result.Length; i++)
            for (var j = 0; j < result[i]; j++)
                res.Add(i - 50000);
        return res;
    }
    // public List<int> SortArray(List<int> nums)
    // {
    //     if (nums.Count <= 1) return nums;
    //     var id = r.Next(nums.Count);
    //     var small = new List<int>();
    //     var same = new List<int>();
    //     var large = new List<int>();
    //     foreach (var n in nums)
    //     {
    //         if (n > nums[id]) large.Add(n);
    //         else if (n == nums[id]) same.Add(n);
    //         else small.Add(n);
    //     }

    //     return small.Concat(same).Concat(large).ToList();
    // }
}
// @lc code=end

