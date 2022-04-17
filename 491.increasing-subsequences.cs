public class Solution
{
    public IList<IList<int>> FindSubsequences(int[] nums, int start = 0, int val = -1000)
    {
        var res = new List<IList<int>>();
        var hs = new HashSet<int>();
        for (var i = start; i < nums.Length; i++)
        {
            if (nums[i] >= val && !hs.Contains(nums[i]))
            {
                res.Add(new List<int>() { nums[i] });
                if (i < nums.Length - 1)
                {
                    foreach (var item in FindSubsequences(nums, i + 1, nums[i]))
                    {
                        item.Insert(0, nums[i]);
                        res.Add(item);
                    }
                }

                hs.Add(nums[i]);
            }
        }
        return start == 0 ? res.Where(x => x.Count >= 2).ToList() : res;
    }
}
// @lc code=end

