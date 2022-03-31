public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        return Subsets(nums, nums.Length - 1);
    }
    public IList<IList<int>> Subsets(int[] nums, int k)
    {

        var list = new List<IList<int>>();
        if (k < 0)
        {
            list.Add(new List<int>());
            return list;
        }
        var element = nums[k];
        var subset = Subsets(nums, k - 1);
        foreach (var s in subset)
        {
            var con = new List<int>();
            con.AddRange(s);

            var con1 = new List<int>();
            con1.AddRange(s);
            con1.Add(element);
            list.Add(con);
            list.Add(con1);
        }
        return list;
    }
}
// @lc code=end

