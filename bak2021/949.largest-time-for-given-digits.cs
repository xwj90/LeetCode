/*
 * @lc app=leetcode id=949 lang=csharp
 *
 * [949] Largest Time for Given Digits
 */

// @lc code=start
public class Solution
{
    public string LargestTimeFromDigits(int[] A)
    {
        int largestTime = -1;
        foreach (var item in A.GetPermutations())
        {
            var array = item.ToArray();
            var min = array[0] * 10 + array[1];
            var sec = array[2] * 10 + array[3];
            if (min < 24 && sec < 59) largestTime = Math.Max(min * 60 + sec);
        }

        return $"{largestTime / 60}:{largestTime % 60}";
    }
}
// @lc code=end

