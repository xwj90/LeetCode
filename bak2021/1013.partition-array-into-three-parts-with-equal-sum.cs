/*
 * @lc app=leetcode id=1013 lang=csharp
 *
 * [1013] Partition Array Into Three Parts With Equal Sum
 */

// @lc code=start
public class Solution
{
    public bool CanThreePartsEqualSum(int[] A)
    {
        var sum = A.Sum();
        var target = sum / 3;
        if (target * 3 != sum) return false;
        var v = 0;
        var count = 0;
        var i=0;
        for ( i = 0; i < A.Length; i++)
        {
            v += A[i];
            if (v == target)
            {
                v = 0;
                count ++;
            }
        }
        return count ==3 && v==0  || (count>3 && v==0 && target==0);
    }
}
// @lc code=end

