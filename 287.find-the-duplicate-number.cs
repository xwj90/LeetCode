/*
 * @lc app=leetcode id=287 lang=csharp
 *
 * [287] Find the Duplicate Number
 */
public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return -1;

        var n = nums.Length - 1;
        var slow = nums[0];
        var fast = nums[nums[0]];
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        fast = 0;
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }
        return slow;
    }
}

