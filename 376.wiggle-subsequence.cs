public class Solution
{
    public int WiggleMaxLength(int[] nums)
    {
        if (nums.Length <= 1)
            return nums.Length;
        var preDiff = 0;
        var count = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            var curDiff = nums[i] - nums[i - 1];
            if (curDiff > 0 && preDiff <= 0 || curDiff < 0 && preDiff >= 0)
            {
                count++;
                preDiff = curDiff;
            }
        }
        return count;
    }
}

