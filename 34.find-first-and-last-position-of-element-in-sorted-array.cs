/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */

// @lc code=start
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        return new int[] {
        BinarySearch(nums, target, true),
        BinarySearch(nums, target, false)
            };

    }

    private int BinarySearch(int[] nums, int target, bool findLeft)
    {
        var left = 0;
        var right = nums.Length - 1;
        var result = -1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                result = mid;
                if (findLeft)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }
}
// @lc code=end

