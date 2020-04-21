/*
 * @lc app=leetcode id=482 lang=csharp
 *
 * [482] License Key Formatting
 */
public class Solution
{
    public string LicenseKeyFormatting(string S, int K)
    {
        var chars = S.ToUpper().Where(p => p != '-');
        var i = K - chars.Count() % K;
        return string.Join("-", chars.GroupBy(p => i++ / K).Select(p => new string(p.ToArray())));
    }
}

