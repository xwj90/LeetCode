public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {

        var res = new int[nums.Length];
        var list = new List<(int val, int id)>();
        for (var i = 0; i < nums.Length; i++)
        {
            list.Add((nums[i], i));
        }

        list.Sort();

        var count = 0;
        for (var i = 0; i < list.Count; i++)
        {
            var (v, id) = list[i];
            var num = 0;
            while (i < list.Count && list[i].val == v)
            {
                res[list[i].id] = count;
                i++;
                num++;
            }
            i--;
            count += num;
        }
        return res;

    }
}
// @lc code=end

