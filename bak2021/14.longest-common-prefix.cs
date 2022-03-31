/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution
{



    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        var s = strs[0];
        foreach (var str in strs)
            if (str.Length < s.Length)
                s = str;


        var arr = s.ToCharArray();
        for (var i = 0; i < strs.Length; i++)
        {
            for (var j = 0; j < strs[i].Length && j < arr.Length; j++)
            {
                if (arr[j] != strs[i][j])
                {
                    arr = arr.Take(j).ToArray();
                }
            }
        }
        return new string(arr);
    }
}
// @lc code=end

