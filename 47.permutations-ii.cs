public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums, int[] status = null, int count = 0)
    {
        if (status == null)
        {
            status = new int[nums.Length];
            Array.Sort(nums);
        }

        var res = new List<IList<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1] && status[i - 1] == 0)
                continue;

            if (status[i] == 0)
            {
                status[i] = 1;
                count++;
                if (count == nums.Length)
                {
                    res.Add(new List<int>() { nums[i] });
                }
                else
                {
                    foreach (var item in PermuteUnique(nums, status, count))
                    {
                        item.Add(nums[i]);
                        res.Add(item);
                    }
                }

                count--;
                status[i] = 0;
            }
        }
        return res;
    }
}
// @lc code=end

