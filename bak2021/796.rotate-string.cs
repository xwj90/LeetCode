/*
 * @lc app=leetcode id=796 lang=csharp
 *
 * [796] Rotate String
 */

// @lc code=start
public class Solution
{
    public bool RotateString(string A, string B)
    {
        if(A==B) return true;
        for (var i = 0; i < A.Length; i++)
            if (B == A.Substring(i, A.Length - i) + A.Substring(0, i))
                return true;
        return false;
    }
}
// @lc code=end

