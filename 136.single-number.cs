/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        long v = 0;
        foreach (var i in nums)
        {
            v = v ^ i;
        }
        return Convert.ToInt32(v);
    }
}

