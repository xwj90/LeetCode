/*
 * @lc app=leetcode id=1191 lang=csharp
 *
 * [1191] K-Concatenation Maximum Sum
 */

// @lc code=start
public class Solution
{
    public int KConcatenationMaxSum(int[] arr, int k)
    {
        var sum = arr.Sum();
        var res = 0;

        var candidates = new List<int>();
        candidates.AddRange(arr);
        if (k > 1) candidates.AddRange(arr);
        var cur = 0;
        for (var i = 0; i < candidates.Count; i++)
        {
            cur += candidates[i];
            if (cur < 0) cur = 0;
            else res = Math.Max(res, cur);
        }
        if (sum > 0)
            for (var i = 2; i < k; i++)
            {
                res += sum;
                res = res % 1000000007;
            }

        return res;
    }
}
// @lc code=end

