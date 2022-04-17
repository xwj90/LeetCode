public class Solution
{
    public IList<IList<int>> Permute(int[] nums, int[] status = null, int count = 0)
    {
        var res = new List<IList<int>>();
        status = status ?? new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
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
                    foreach (var item in Permute(nums, status, count))
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

