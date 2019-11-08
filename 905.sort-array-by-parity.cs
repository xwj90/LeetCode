/*
 * @lc app=leetcode id=905 lang=csharp
 *
 * [905] Sort Array By Parity
 */

// @lc code=start
public class Solution
{
    public int[] SortArrayByParity(int[] A)
    {
        var left = 0;
        var right = A.Length - 1;
        while (left < right)
        {
            if (A[left] % 2 == 0)
            {
                left++;
            }
            else
            {
                var temp = A[right];
                A[right] = A[left];
                A[left] = temp;
                right--;
            }
        }
        return A;
    }
}
// @lc code=end

