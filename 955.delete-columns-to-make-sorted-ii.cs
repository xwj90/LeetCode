/*
 * @lc app=leetcode id=955 lang=csharp
 *
 * [955] Delete Columns to Make Sorted II
 */

// @lc code=start
public class Solution
{
    public int MinDeletionSize(string[] A)
    {
        var cuts = new bool[A.Length - 1]; // if previous value is makec urrent value valid
        int ans = 0;
        for (var j = 0; j < A[0].Length; j++)
        {
            var isBreak = false;
            for (var i = 0; i < A.Length - 1; i++)
                if (!cuts[i] && A[i][j] > A[i + 1][j])
                {
                    ans++;
                    isBreak = true;
                    break;
                }

            if (isBreak) continue;
            
            for (var i = 0; i < A.Length - 1; i++)
                if (A[i][j] < A[i + 1][j])
                    cuts[i] = true;
        }
        return ans;
    }
}

