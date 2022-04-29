/*
 * @lc app=leetcode id=941 lang=csharp
 *
 * [941] Valid Mountain Array
 */

// @lc code=start
public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        var left = 0;
        var right = arr.Length - 1;

        while (left < arr.Length - 1 && arr[left] < arr[left + 1])
            left++;

        while (right > 0 && arr[right - 1] > arr[right])
            right--;

        return left == right && left != 0 && right != arr.Length - 1;

    }
}
// @lc code=end

