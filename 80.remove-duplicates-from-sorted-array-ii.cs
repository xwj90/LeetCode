public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if(nums.Length==0) return 0;
        
        var slow = 0;
        var currentValue = nums[0];
        var currentIds = new List<int>() { 0 };
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != currentValue)
            {
                var newIds = new List<int>() { i };
                var newValue = nums[i];
                for (var j = 0; j < Math.Min(currentIds.Count, 2); j++)
                {
                    nums[slow++] = currentValue;
                }
                currentValue = newValue;
                currentIds = newIds;
            }
            else
            {
                currentIds.Add(i);
            }
        }

        for (var j = 0; j < Math.Min(currentIds.Count, 2); j++)
        {
            nums[slow++] = currentValue;
        }
        return slow ;
    }
}
// @lc code=end

