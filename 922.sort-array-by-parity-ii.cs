/*
 * @lc app=leetcode id=922 lang=csharp
 *
 * [922] Sort Array By Parity II
 */

// @lc code=start
public class Solution
{
    public int[] SortArrayByParityII(int[] A)
    {

        var even = 0;
        var odd = A.Length - 1;
        if (odd % 2 == 0) odd = odd - 1;

        while (even < A.Length && odd > 0)
        {
            if (A[even] % 2 == 0) even += 2;
            else if (A[odd] % 2 == 1) odd -= 2;
            else
            {
                var temp = A[even];
                A[even] = A[odd];
                A[odd] = temp;
            }
        }
        return A;
    }
}
// @lc code=end

