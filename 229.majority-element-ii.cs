public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        var count1 = 0;
        var count2 = 0;
        var value1 = 0;
        var value2 = 0;
        foreach (var n in nums)
        {
            if (value1 == n) count1++;
            else if (value2 == n) count2++;
            else if (count1 == 0) (value1, count1) = (n, 1);
            else if (count2 == 0) (value2, count2) = (n, 1);
            else
            {
                count1--;
                count2--;
            }
        }
        var res = new List<int>();
        if (nums.Count(p => p == value1) > nums.Length / 3) res.Add(value1);
        if (nums.Count(p => p == value2) > nums.Length / 3 && value2 != value1) res.Add(value2);
        return res;
    }
}
// @lc code=end

